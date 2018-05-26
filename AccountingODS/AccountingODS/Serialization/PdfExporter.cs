using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AccountingODS.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AccountingODS.Serialization
{
    public class PdfExporter : IDisposable
    {
        private FileStream stream;
        private Document document;
        private PdfWriter writer;

        /// <summary>
        /// Creates new PDF file, and exports the specified invoices to 
        /// PDF file specified by pathToPdf.
        /// PathToPdf must be provided including filename.
        /// </summary>
        /// <param name="invoices">Invoices.</param>
        /// <param name="pathToPdf">Path to pdf.</param>
        public void Export(IList<Invoice> invoices, string pathToPdf) 
        {
            if (invoices.Count == 0) {
                return;
            }
            Initialize(pathToPdf);
            ProcessList(invoices);
            document.Close();
        }

        public void Dispose()
        {
            stream.Dispose();
            document.Dispose();
            writer = null;
        }

        private void Initialize(string path) 
        {
            stream = CreatePdf(path);
            OpenPdf();

        }

        private FileStream CreatePdf(string path) 
        {
            return new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None);
        }

        private void OpenPdf()
        {
            document = new Document();
            writer = PdfWriter.GetInstance(document, stream);
            document.Open();
        }

        private void ProcessList(IList<Invoice> invoices) 
        {
            foreach (var invoice in invoices) 
            {
                ProcessInvoice(invoice);

            }
        }

        private void ProcessInvoice(Invoice invoice)
        {
            document.Add(CreateSingleLine("Invoice number", invoice.InvoiceNumber));
            document.Add(CreateSingleLine("Invoice type", invoice.Type.ToString()));
            document.Add(CreateSingleLine("Invoice date", invoice.InvoiceDate.ToString()));
            document.Add(CreateSingleLine("Maturity date", invoice.MaturityDate.ToString()));

            AddRangeToDocument(CreateMultiLine("Creditor", GetPersonInfo(invoice.Creditor)));
            AddRangeToDocument(CreateMultiLine("Debtor", GetPersonInfo(invoice.Debtor)));
            AddRangeToDocument(CreateMultiLine("Items", invoice.InvoicedItems.Select(i => CreateSingleLine(i.Name, i.Cost.ToString() + " CZK", 145)).ToArray()));

            document.Add(CreateSingleLine("Total invoice cost", invoice.InvoicedItems.Sum(i => i.Cost).ToString()));

            document.Add(new Paragraph(HorizontalRow()));
            document.Add(new Paragraph(Environment.NewLine));
        }

        private string[] GetPersonInfo(Person person) {
            return new string[] { person.FullName, person.Adress, person.ZIPCode };
        }

        private Paragraph CreateSingleLine(string title, string value, float indent = 0) 
        {
            Paragraph paragraph = new Paragraph(title + ":  ");
            paragraph.Add(Chunk.TABBING);
            paragraph.Add(Chunk.TABBING);
            paragraph.IndentationLeft = indent;
            paragraph.Add(value);
            return paragraph;
        }

        private Paragraph[] CreateMultiLine(string title, string[] values)
        {
            var result = new List<Paragraph>();

            result.Add(new Paragraph(title + ": "));
            foreach (var value in values) 
            {
                var paragraph = new Paragraph(value);
                paragraph.IndentationLeft = 145;
                result.Add(paragraph);
            }
            return result.ToArray();
        }

        private Paragraph[] CreateMultiLine(string title, Paragraph[] values)
        {
            var result = new List<Paragraph>();

            result.Add(new Paragraph(title + ": "));
            foreach (var value in values)
            {
                value.IndentationLeft = 145;
                result.Add(value);
            }
            return result.ToArray();
        }

        private void AddRangeToDocument(Paragraph[] paragraphs)
        {
            foreach (var paragraph in paragraphs)
            {
                document.Add(paragraph);
            }
        }

        private string HorizontalRow() 
        {
            return new string('_', 77);
        }
    }
}
