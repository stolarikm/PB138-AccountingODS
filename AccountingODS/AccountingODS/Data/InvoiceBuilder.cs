using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingODS.Data
{
    public class InvoiceBuilder
    {
        private string invoiceNumber;
        private Person creditor;
        private Person debtor;
        private DateTime invoiceDate;
        private DateTime maturityDate;
        private InvoiceType type;
        private List<InvoiceItem> invoicedItems = new List<InvoiceItem>();
        

        public InvoiceBuilder SetInvoiceNumber(string number)
        {
            invoiceNumber = number;
            return this;
        }

        public InvoiceBuilder SetCreditor(Person creditor)
        {
            this.creditor = creditor;
            return this;
        }

        public InvoiceBuilder SetDebtor(Person debtor)
        {
            this.debtor = debtor;
            return this;
        }

        public InvoiceBuilder SetInvoiceDate(DateTime date)
        {
            invoiceDate = date;
            return this;
        }

        public InvoiceBuilder SetMaturityDate(DateTime date)
        {
            maturityDate = date;
            return this;
        }

        public InvoiceBuilder SetInvoicedItems(IList<InvoiceItem> invoicedItems)
        {
            this.invoicedItems = new List<InvoiceItem>(invoicedItems);
            return this;
        }

        public InvoiceBuilder SetInvoiceType(InvoiceType type)
        {
            this.type = type;
            return this;
        }


        public Invoice Build()
        {
            Invoice invoice = new Invoice();
            invoice.Creditor = creditor;
            invoice.Debtor = debtor;
            invoice.InvoiceDate = invoiceDate;
            invoice.InvoicedItems = invoicedItems;
            invoice.MaturityDate = maturityDate;
            invoice.Type = type;
            invoice.InvoiceNumber = invoiceNumber;
            return invoice;
        }

    }
}
