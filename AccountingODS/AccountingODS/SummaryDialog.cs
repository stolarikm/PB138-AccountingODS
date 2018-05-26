using System;
using System.Linq;
using System.Collections.Generic;
using AccountingODS.Data;

namespace AccountingODS
{
    public partial class SummaryDialog : Gtk.Dialog
    {
		public SummaryDialog(IEnumerable<Invoice> debts, IEnumerable<Invoice> credits)
        {
            this.Build();

			var incomes = credits.Sum(Invoice => Invoice.InvoicedItems.Sum(item => item.Cost));
			var expenditures = debts.Sum(Invoice => Invoice.InvoicedItems.Sum(item => item.Cost));
			labelIncomes.Text = incomes + " CZK";
			labelExpenditures.Text = expenditures + " CZK";
			labelDifference.Text = (incomes - expenditures) + " CZK";
			buttonCancel.IsFocus = false;
        }

		protected void OnButtonCancelClicked(object sender, EventArgs e)
		{
			this.Destroy();
		}
	}
}
