using System;
namespace AccountingODS.Data
{
    public class InvoiceItem
    {
        public InvoiceItem(decimal cost, string name)
		{
			Cost = cost;
			Name = name;
		}

		public decimal Cost { get; }
		public string Name { get; }
    }
}
