using System;
using System.Collections.Generic;

namespace AccountingODS.Data
{
	public class Invoice
	{

        public Invoice()
        {

        }


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

		public string InvoiceNumber { get; set; }
		public InvoiceType Type { get; set; }
		public Person Debtor { get; set; }
		public Person Creditor { get; set; }
		public DateTime InvoiceDate { get; set; }
		public DateTime MaturityDate { get; set; }
		public List<InvoiceItem> InvoicedItems { get; set; }
	}
}