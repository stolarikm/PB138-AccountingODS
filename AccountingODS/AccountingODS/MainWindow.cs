using System;
using System.Collections.Generic;
using System.Reflection;
using AccountingODS.Data;
using Gtk;

public partial class MainWindow : Window
{
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
	}

	[TreeNode(ListOnly = true)]
	private class InvoiceNode : TreeNode
	{
		Invoice Invoice;

		public InvoiceNode(Invoice invoice)
		{
			this.Invoice = invoice;
		}

		[TreeNodeValue(Column = 0)]
		public string InvoiceDate { get { return Invoice.InvoiceDate.ToString("dd.MM.yyyy"); }}

		[TreeNodeValue(Column = 1)]
		public string MaturityDate { get { return Invoice.MaturityDate.ToString("dd.MM.yyyy"); }}

	}

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
