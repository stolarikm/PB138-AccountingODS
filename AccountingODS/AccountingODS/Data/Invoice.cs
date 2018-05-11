using System;
using System.Collections.Generic;

namespace AccountingODS.Data
{
	public class Invoice
	{
		public Invoice(string invoiceNumber, InvoiceType type, Person debtor, Person creditor, DateTime invoiceDate, DateTime maturityDate, List<InvoiceItem> invoicedItems)
		{
			InvoiceNumber = invoiceNumber;
			Type = type;
			Debtor = debtor;
			Creditor = creditor;
			InvoiceDate = invoiceDate;
			MaturityDate = maturityDate;
			InvoicedItems = new List<InvoiceItem>(invoicedItems);
		}

		public Invoice(string invoiceNumber, InvoiceType type, Person debtor, Person creditor, DateTime invoiceDate, DateTime maturityDate)
        {
			InvoiceNumber = invoiceNumber;
            Type = type;
            Debtor = debtor;
            Creditor = creditor;
            InvoiceDate = invoiceDate;
            MaturityDate = maturityDate;
			InvoicedItems = new List<InvoiceItem>();
        }

		public string InvoiceNumber { get; }
		public InvoiceType Type { get; }
		public Person Debtor { get; }
		public Person Creditor { get; }
		public DateTime InvoiceDate { get; }
		public DateTime MaturityDate { get; }
		public List<InvoiceItem> InvoicedItems { get; }
	}
}