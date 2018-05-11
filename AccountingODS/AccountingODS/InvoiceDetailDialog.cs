using System;
using System.Reflection;
using AccountingODS.Data;
using Gtk;

namespace AccountingODS
{
    public partial class InvoiceDetailDialog : Gtk.Dialog
    {
        public InvoiceDetailDialog(Invoice invoice)
        {
            this.Build();

			var nodeStore = new NodeStore(typeof(InvoiceItemNode));
            nodeview.NodeStore = nodeStore;
            //workaround for bug (not setting NodeStore)
            typeof(NodeView).GetField("store", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(nodeview, nodeStore);

			foreach (var item in invoice.InvoicedItems) {
				nodeview.NodeStore.AddNode(new InvoiceItemNode(item));
			}

			nodeview.AppendColumn("Invoice item text", new CellRendererText(), "text", 0);
			nodeview.AppendColumn("Invoice item cost", new CellRendererText(), "text", 1);

			labelType.Text = invoice.Type.ToString();
			labelNumber.Text = invoice.InvoiceNumber;
			labelDebtorName.Text = invoice.Debtor.FullName;
			labelDebtorAdress.Text = invoice.Debtor.Adress;
			labelDebtorZIP.Text = invoice.Debtor.ZIPCode;
			labelCreditorName.Text = invoice.Creditor.FullName;
			labelCreditorAdress.Text = invoice.Creditor.Adress;
			labelCreditorZIP.Text = invoice.Creditor.ZIPCode;
			labelInvoiceDate.Text = invoice.InvoiceDate.ToString("dd.MM.yyyy");
			labelMaturityDate.Text = invoice.MaturityDate.ToString("dd.MM.yyyy");
        }

        [TreeNode(ListOnly = true)]
		private class InvoiceItemNode : TreeNode {
			public InvoiceItem item;

			public InvoiceItemNode(InvoiceItem item)
			{
				this.item = item;
			}

			[TreeNodeValue(Column = 0)]
			public string Name { get { return item.Name; }}

			[TreeNodeValue(Column = 1)]
			public string Cost { get { return item.Cost.ToString(); } }
		}

		protected void OnButtonCancelClicked(object sender, EventArgs e)
		{
			this.Destroy();
		}
	}
}
