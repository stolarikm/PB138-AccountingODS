using System;
using System.Collections.Generic;

namespace AccountingODS.Data
{
	public class Invoice
	{
		public Invoice(InvoiceType type, Person debtor, Person creditor, DateTime invoiceDate, DateTime maturityDate, List<InvoiceItem> invoicedItems)
		{
			Type = type;
			Debtor = debtor;
			Creditor = creditor;
			InvoiceDate = invoiceDate;
			MaturityDate = maturityDate;
			InvoicedItems = invoicedItems;
		}

		public InvoiceType Type { get; }
		public Person Debtor { get; }
		public Person Creditor { get; }
		public DateTime InvoiceDate { get; }
		public DateTime MaturityDate { get; }
		public List<InvoiceItem> InvoicedItems { get; }
	}
}