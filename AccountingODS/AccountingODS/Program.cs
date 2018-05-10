using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using AccountingODS.Data;
using AccountingODS.Serialization;
using Gtk;


namespace AccountingODS
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            Application.Init();
			MainWindow win = new MainWindow();
			win.Title = "AccountingODS";
            win.Show();
            Application.Run();


            /*
            var wrapper = new OdsWrapper();
            wrapper.ExctractXmlFromODS(Paths.InputFolderPath + "odsToExtract.ods", Paths.OutputFolderPath);
            wrapper.InsertXmlToODS(Paths.OutputFolderPath, Paths.OutputFolderPath + "extractedOds.ods");
            */

            /*
            var items = new List<InvoiceItem> { new InvoiceItem(20, "Hlupost"), new InvoiceItem(50, "Blbost"), new InvoiceItem(10, "Somarina") };
            var i1 = new Invoice(InvoiceType.CREDIT, new Person("Jiri Korn", "Praha 2", "60000"), new Person("Helenka Vondrackova", "Praha 5", "60005"), DateTime.Now, DateTime.Now, items);
            var i2 = new Invoice(InvoiceType.DEBT, new Person("Cigan Prvy", "Nikde 0", "00000"), new Person("Cigan Druhy", "Hybe 12", "12345"), DateTime.Now, DateTime.Now, items);
            IList<Invoice> data = new List<Invoice> { i1, i2 };
            using (PdfExporter exporter = new PdfExporter()) {
                exporter.Export(data, Paths.OutputFolderPath + "pfdOutput.pdf");
            }
            */
        }
    }
}
