using System;
using System.Collections.Generic;
using AccountingODS.Data;
using Gtk;

public partial class MainWindow : Gtk.Window
{
	NodeStore store;
    NodeStore Store
    {
        get
        {
            if (store == null)
            {
                store = new NodeStore(typeof(Invoice));
                store.AddNode(new InvoiceNode(new Invoice(InvoiceType.CREDIT
                              , new Person("name", "adress", "code")
                              , new Person("name", "adress", "code")
                              , DateTime.Now
                              , DateTime.Now
                              , new List<InvoiceItem> { new InvoiceItem(1.0m, "type"), new InvoiceItem(10.0m, "item") })));
            }
            return store;
        }
    }

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
		nodeview = new NodeView(store);
		Add(nodeview);
		nodeview.AppendColumn("debtor name", new CellRendererText(), "text", 0);
		nodeview.ShowAll();

		ShowAll();
        Build();
    }

	public class InvoiceNode : TreeNode
	{
		Invoice invoice;

		public InvoiceNode(Invoice invoice)
		{
			this.invoice = invoice;
		}

		[TreeNodeValue(Column = 0)]
		public string DebtorName { get { return invoice.Debtor.FullName; }}

		[TreeNodeValue(Column = 1)]
		public string CreditorName { get { return invoice.Creditor.FullName; }}

		[TreeNodeValue(Column = 2)]
		public DateTime InvoiceDate { get { return invoice.InvoiceDate; }}

		[TreeNodeValue(Column = 3)]
		public DateTime MaturityDate { get { return invoice.MaturityDate; }}

	}

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }
}
