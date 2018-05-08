using System;
namespace AccountingODS.Data
{
    public class Person
    {
		public Person(string fullName, string adress, string zIPCode)
		{
			FullName = fullName;
			Adress = adress;
			ZIPCode = zIPCode;
		}

		public string FullName { get; }
		public string Adress { get; }
		public string ZIPCode { get; }
    }
}
