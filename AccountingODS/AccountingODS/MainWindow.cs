using System;
using System.Collections.Generic;
using System.Reflection;
using AccountingODS.Data;
using Gtk;
using System.Linq;

public partial class MainWindow : Window
{
	private NodeView lastNodeFocused;

	public MainWindow() : base(WindowType.Toplevel)
    {
		Build();

		//TODO: get invoices from ods
		List<Invoice> credits = new List<Invoice>{
			new Invoice(InvoiceType.CREDIT
							  , new Person("name", "adress", "code"), new Person("name2", "adress2", "code2")
							  , DateTime.Now, DateTime.Now
							  , new List<InvoiceItem> { new InvoiceItem(1.0m, "type"), new InvoiceItem(10.0m, "item") })
		};
		List<Invoice> debts = new List<Invoice> {
			new Invoice(InvoiceType.DEBT
                              , new Person("name", "adress", "code"), new Person("name2", "adress2", "code2")
                              , DateTime.Now, DateTime.Now
                              , new List<InvoiceItem> { new InvoiceItem(1.0m, "type"), new InvoiceItem(10.0m, "item") })
        };

		populateNodeview(nodeviewCredit, credits);
		populateNodeview(nodeviewDebt, debts);

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
		nodeView.AppendColumn("Invoice date", new CellRendererText(), "text", 0);
		nodeView.AppendColumn("Maturity date", new CellRendererText(), "text", 1);
		nodeView.AppendColumn("Total price", new CellRendererText(), "text", 2);
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
		public string InvoiceDate { get { return Invoice.InvoiceDate.ToString("dd.MM.yyyy"); }}

		[TreeNodeValue(Column = 1)]
		public string MaturityDate { get { return Invoice.MaturityDate.ToString("dd.MM.yyyy"); }}

		[TreeNodeValue(Column = 2)]
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
		var invoice = new Invoice(type, debtor, creditor, calendarInvoiceDate.Date, calendarMaturityDate.Date);

		switch(type) {
			case InvoiceType.CREDIT:
				nodeviewCredit.NodeStore.AddNode(new InvoiceNode(invoice));
				break;
			case InvoiceType.DEBT:
				nodeviewDebt.NodeStore.AddNode(new InvoiceNode(invoice));
				break;
		}
		//TODO: add new invoice to ods

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
		if (decimal.TryParse(entryInvoiceItemCost.Text, out decimal cost)) {
			var item = new InvoiceItem(cost, entryInvoiceItemName.Text);
			(lastNodeFocused.NodeSelection.SelectedNode as InvoiceNode)?.Invoice.InvoicedItems.Add(item);
			lastNodeFocused.IsFocus = true;
			//TODO: add new item to ods

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
			//TODO: remove invoice from ods
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
}
