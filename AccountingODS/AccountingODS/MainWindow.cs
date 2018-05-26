using System;
using System.Collections.Generic;
using System.Reflection;
using AccountingODS.Data;
using Gtk;
using System.Linq;
using AccountingODS;
using AccountingODS.Serialization;

public partial class MainWindow : Window
{
	private NodeView lastNodeFocused;
	private List<Invoice> creditInvoices;
	private List<Invoice> debtInvoices;

	public MainWindow() : base(WindowType.Toplevel)
    {
		Build();

		//TODO: get invoices from ods
		creditInvoices = new List<Invoice>{
			new Invoice("91526135", InvoiceType.CREDIT
							  , new Person("Antonin Repa", "Jaselska 20, Brno", "60200"), new Person("Frantisek Novak", "Botanicka 65, Brno", "60200")
			            , DateTime.Parse("2018-5-30"), DateTime.Parse("2018-5-31")
			            , new List<InvoiceItem> { new InvoiceItem(2499.0m, "Monitor"), new InvoiceItem(399.0m, "Klavesnica"), new InvoiceItem(349.0m, "Herna mys"), new InvoiceItem(1999.0m, "Headset") })
		};
		debtInvoices = new List<Invoice> {
			new Invoice("248965", InvoiceType.DEBT
                              , new Person("Frantisek Novak", "Botanicka 65, Brno", "60200"), new Person("Miroslav Krajnak", "Mudronova 20, Presov", "08001")
			            , DateTime.Parse("2018-5-1"), DateTime.Parse("2018-5-29")
			            , new List<InvoiceItem> { new InvoiceItem(29468.50m, "Bicykel"), new InvoiceItem(10.0m, "Jablko"), new InvoiceItem(10.0m, "Jablko"), new InvoiceItem(10.20m, "Jablko") })
        };

		populateNodeview(nodeviewCredit, creditInvoices);
		populateNodeview(nodeviewDebt, debtInvoices);

		foreach (var value in Enum.GetValues(typeof(InvoiceType))) {
			comboboxType.AppendText(value.ToString());	
		}
		comboboxType.Active = 0;
    }

	private void populateNodeview(NodeView nodeView, List<Invoice> invoices) {
		var nodeStore = new NodeStore(typeof(InvoiceNode));
		nodeView.NodeStore = nodeStore;
		//workaround for bug (not setting NodeStore)
		typeof(NodeView).GetField("store", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(nodeView, nodeStore);

		foreach (var invoice in invoices) {
			nodeView.NodeStore.AddNode(new InvoiceNode(invoice));	
		}
		nodeView.AppendColumn("Invoice number", new CellRendererText(), "text", 0);
		nodeView.AppendColumn("Invoice date", new CellRendererText(), "text", 1);
		nodeView.AppendColumn("Maturity date", new CellRendererText(), "text", 2);
		nodeView.AppendColumn("Total price", new CellRendererText(), "text", 3);
	}

	[TreeNode(ListOnly = true)]
	private class InvoiceNode : TreeNode
	{
		public Invoice Invoice;

		public InvoiceNode(Invoice invoice)
		{
			this.Invoice = invoice;
		}

		[TreeNodeValue(Column = 0)]
		public string InvoiceNumber { get { return Invoice.InvoiceNumber; }}

        [TreeNodeValue(Column = 1)]
        public string InvoiceDate { get { return Invoice.InvoiceDate.ToString("dd.MM.yyyy"); }}

        [TreeNodeValue(Column = 2)]
        public string MaturityDate { get { return Invoice.MaturityDate.ToString("dd.MM.yyyy"); }}

        [TreeNodeValue(Column = 3)]
        public string Cost {
            get {
                return Invoice.InvoicedItems.Count == 0 ? "0" : Invoice.InvoicedItems.Sum(x => x.Cost).ToString("G");
            }
        }


	}

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

	protected void OnButtonAddInvoiceClicked(object sender, EventArgs e)
	{
		var debtor = new Person(entryDebtorName.Text, entryDebtorAdress.Text, entryDebtorZip.Text);
		var creditor = new Person(entryCreditorName.Text, entryCreditorAdress.Text, entryCreditorZip.Text);
		Enum.TryParse(comboboxType.ActiveText, out InvoiceType type);
		var invoice = new Invoice(entryInvoiceNumber.Text, type, debtor, creditor, calendarInvoiceDate.Date, calendarMaturityDate.Date);

		switch(type) {
			case InvoiceType.CREDIT:
				nodeviewCredit.NodeStore.AddNode(new InvoiceNode(invoice));
				creditInvoices.Add(invoice);
				break;
			case InvoiceType.DEBT:
				nodeviewDebt.NodeStore.AddNode(new InvoiceNode(invoice));
				debtInvoices.Add(invoice);
				break;
		}

		new Serializer(creditInvoices.Concat(debtInvoices).ToList()).Serialize();

		entryInvoiceNumber.Text = String.Empty;
		entryDebtorName.Text = String.Empty;
		entryDebtorAdress.Text = String.Empty;
		entryDebtorZip.Text = String.Empty;
		entryCreditorName.Text = String.Empty;
		entryCreditorAdress.Text = String.Empty;
		entryCreditorZip.Text = String.Empty;
		calendarInvoiceDate.Date = DateTime.Today;
		calendarMaturityDate.Date = DateTime.Today;
	}

	protected void OnButtonAddInvoiceItemClicked(object sender, EventArgs e)
	{
		if (lastNodeFocused == null) return;

		if (decimal.TryParse(entryInvoiceItemCost.Text, out decimal cost)) {
			var item = new InvoiceItem(cost, entryInvoiceItemName.Text);
			(lastNodeFocused.NodeSelection?.SelectedNode as InvoiceNode)?.Invoice.InvoicedItems.Add(item);
			lastNodeFocused.IsFocus = true;

			new Serializer(creditInvoices.Concat(debtInvoices).ToList()).Serialize();

			entryInvoiceItemCost.Text = String.Empty;
			entryInvoiceItemName.Text = String.Empty;
		}
		else {
			var color = new Gdk.Color();
            Gdk.Color.Parse("red", ref color);
			entryInvoiceItemCost.ModifyBase(StateType.Normal, color);
		}
	}

	protected void OnButtonDeleteInvoiceClicked(object sender, EventArgs e)
	{
		if (lastNodeFocused == null) return;
		var invoice = lastNodeFocused.NodeSelection.SelectedNode as InvoiceNode;
		if (invoice != null) {
			lastNodeFocused.NodeStore.RemoveNode(invoice);
			switch (invoice.Invoice.Type) {
				case InvoiceType.CREDIT:
					creditInvoices.Remove(invoice.Invoice);
					break;
				case InvoiceType.DEBT:
					debtInvoices.Remove(invoice.Invoice);
					break;
			}

			new Serializer(creditInvoices.Concat(debtInvoices).ToList()).Serialize();
        }
	}

	protected void OnSetFocus(object o, SetFocusArgs args)
	{
		if (args.Focus is NodeView) {
			lastNodeFocused = args.Focus as NodeView;
		}
	}

    protected void OnEntryInvoiceItemCostChanged(object sender, EventArgs e)
    {
		var color = new Gdk.Color();
		Gdk.Color.Parse("white", ref color);
		entryInvoiceItemCost.ModifyBase(StateType.Normal, color);
	}

	protected void OnButtonShowInvoiceDetailClicked(object sender, EventArgs e)
	{
		if (lastNodeFocused == null) return;

		var invoice = lastNodeFocused.NodeSelection.SelectedNode as InvoiceNode;

		if (invoice == null) return;

		new InvoiceDetailDialog(invoice.Invoice).Run();
        
	}

	protected void OnButtonExportToPdfClicked(object sender, EventArgs e)
	{
		new PdfExporter().Export(creditInvoices.Concat(debtInvoices).ToList(), System.IO.Path.Combine(Paths.OutputFolderPath, $"InvoicesExport{DateTime.Today.ToString("dd_MM_yyyy")}.pdf"));
	}

	protected void OnButton11Clicked(object sender, EventArgs e)
	{
		new SummaryDialog(debtInvoices, creditInvoices).Run();
	}
}
