using AccountingODS.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace AccountingODS.Serialization
{
    public class Serializer : ISerializer
    {
        public IList<Invoice> Invoices { get; private set; } = new List<Invoice>();
        public int RowCount { get; private set; } = 1;
        public int TableCount { get; private set; } = 3;
        public XElement CurrentTable { get; private set; }

        public Serializer(IList<Invoice> invoices)
        {
            Invoices = invoices;
        }



        public void Serialize()
        {
            var wrapper = new OdsWrapper();
            wrapper.ExctractXmlFromODS(Paths.InputFolderPath + Path.DirectorySeparatorChar + "template.ods", Paths.InputFolderPath + Path.DirectorySeparatorChar);
            XDocument doc = XDocument.Load(Paths.InputFolderPath + Path.DirectorySeparatorChar + "content.xml");
            var root = doc.Root;

            var spreadsheet = root.Descendants()
                                  .Where(element => element.Name.LocalName == "spreadsheet")
                                  .First();
            AddNewTables(spreadsheet);

            var tables = root.Descendants()
                        .Where(element => element.Name.LocalName == "table")
                        .ToList();

            
            for (int i = 0; i < Invoices.Count; i++)
            {
                SerializeInvoice(Invoices.ElementAt(i), tables.ElementAt(i));
            }
            doc.Save(Paths.InputFolderPath + "content.xml");
            wrapper.InsertXmlToODS(Paths.InputFolderPath, Paths.OutputFolderPath + "result.ods");
        }


        /// <summary>
        /// Serializes an invoice
        /// </summary>
        /// <param name="invoice">Invoice which is to be serialized</param>
        public void SerializeInvoice(Invoice invoice, XElement table)
        {
            PrepareTable(table);
            FillTable(invoice, table);            
        }


        private void AddNewTables(XElement spreadsheet)
        {
            if (Invoices.Count <= TableCount)
            {
                return;
            }

            var expressionElement = spreadsheet.Elements().Where(element => element.Name.LocalName == "named-expressions").First();
            expressionElement?.Remove();

            XNamespace tableNs = "urn:oasis:names:tc:opendocument:xmlns:table:1.0";
            for (int i = 3; i < Invoices.Count; i++)
            {
                XElement table = new XElement(tableNs + "table");
                InitNewTable(table, tableNs);
                spreadsheet.Add(table);
            }
            spreadsheet.Add(expressionElement);
        } 


        private void InitNewTable(XElement table, XNamespace tableNamespace)
        {
            AddColumn(table, tableNamespace, 1);
            AddColumn(table, tableNamespace, 2);

            TableCount++;
            table.SetAttributeValue(tableNamespace + "name", "Sheet" + TableCount);
            table.SetAttributeValue(tableNamespace + "style-name", "ta1");
            table.SetAttributeValue(tableNamespace + "print", "false");
        }


        private void AddColumn(XElement table, XNamespace ns, int columnNumber)
        {
            var column = new XElement(ns + "table-column");
            column.SetAttributeValue(ns + "style-name", "co" + columnNumber);
            column.SetAttributeValue(ns + "default-cell-style-name", "Default");
            table.Add(column);
        }


        /// <summary>
        /// Fills the table with all necessary data
        /// </summary>
        /// <param name="table"></param>
        private void FillTable(Invoice invoice, XElement table)
        {
            FillInvoiceHeader(invoice, GetNthRow(table, 1));
            FillSecondRow(invoice, GetNthRow(table, 2));
            FillThirdRow(invoice, GetNthRow(table, 3));
            FillFourthRow(GetNthRow(table, 4));
            FillInfoOfInvolvedPeople(invoice, GetNthRow(table, 5), GetNthRow(table, 6), GetNthRow(table, 7));
            FillInvoicedGoodsTable(invoice, table);
        }


        /// <summary>
        /// Returns wanted row of the table
        /// </summary>
        /// <param name="table">Table element</param>
        /// <param name="rowNumber">Number of the row</param>
        /// <returns>Row element</returns>
        private XElement GetNthRow(XElement table, int rowNumber)
        {
            return table.Elements()
                        .Where(element => element.Name.LocalName == "table-row")
                        .ToList()
                        .ElementAt(rowNumber - 1);
        }

        /// <summary>
        /// Fills the second row of the document with the invoice date
        /// </summary>
        /// <param name="table">table element of the document</param>
        private void FillSecondRow(Invoice invoice, XElement secondRow)
        {
            secondRow.Add(InitCell("Invoice date:"));

            secondRow.Add(InitCell(invoice.InvoiceDate.Date.ToString("dd/MM/yyyy")));
            secondRow.Add(InitCell(""));

            secondRow.Add(InitCell("Type:"));
            secondRow.Add(InitCell(invoice.Type.ToString()));
        }


        /// <summary>
        /// Fills the third row of the table
        /// </summary>
        /// <param name="thirdRow">Third row element</param>
        private void FillThirdRow(Invoice invoice, XElement thirdRow)
        {
            thirdRow.Add(InitCell("Payment due by:"));
            thirdRow.Add(InitCell(invoice.MaturityDate.Date.ToString("dd/MM/yyyy")));

            decimal sum = invoice.InvoicedItems.Sum(item => item.Cost);
            thirdRow.Add(InitCell(""));
            thirdRow.Add(InitCell("Sum:"));
            thirdRow.Add(InitCell(sum.ToString()));
        }


        /// <summary>
        /// Fills fourth row of the table
        /// </summary>
        /// <param name="fourthRow">Fourth row element</param>
        private void FillFourthRow(XElement fourthRow)
        {     
            fourthRow.Add(InitCell("Creditor"));
            AddEmptyCells(fourthRow);
            fourthRow.Add(InitCell("Debtor"));
        }


        /// <summary>
        /// Adds empty cells to the table
        /// </summary>
        /// <param name="row">Row which empty cells will be added to</param>
        private void AddEmptyCells(XElement row)
        {
            const int EMPTY_SPACE_COUNT = 2;
            for (int i = 0; i < EMPTY_SPACE_COUNT; i++)
            {
                row.Add(InitCell(""));
            }
        }


        /// <summary>
        /// Fills info about the creditor and the debtor
        /// </summary>
        /// <param name="fifthRow">Fifth row</param>
        /// <param name="sixthRow">Sixth row</param>
        /// <param name="seventhRow">Seventh row</param>
        private void FillInfoOfInvolvedPeople(Invoice invoice, XElement fifthRow, XElement sixthRow, XElement seventhRow)
        {
            fifthRow.Add(InitCell(invoice.Creditor.FullName));
            AddEmptyCells(fifthRow);
            fifthRow.Add(InitCell(invoice.Debtor.FullName));

            sixthRow.Add(InitCell(invoice.Creditor.Adress));
            AddEmptyCells(sixthRow);
            sixthRow.Add(InitCell(invoice.Debtor.Adress));

            seventhRow.Add(InitCell(invoice.Creditor.ZIPCode));
            AddEmptyCells(seventhRow);
            seventhRow.Add(InitCell(invoice.Debtor.ZIPCode));
        }


        /// <summary>
        /// Fills first row of the XML invoice
        /// </summary>
        /// <param name="table">Table Element</param>
        private void FillInvoiceHeader(Invoice invoice, XElement firstRow)
        {
            firstRow.Add(InitCell("Invoice"));
            firstRow.Add(InitCell(invoice.InvoiceNumber));
        }


        private void PrepareTable(XElement table)
        {
            RowCount = 1;
            for (int j = 1; j < 10; j++)
            {
                AddRow(table);
            }
        }


        /// <summary>
        /// Creates new cell element with text child
        /// </summary>
        /// <param name="value">Text value</param>
        /// <returns>Initialized cell element</returns>
        private XElement InitCell(string value)
        {
            XNamespace ns = "urn:oasis:names:tc:opendocument:xmlns:table:1.0";
            var cell = new XElement(ns + "table-cell");

            var valueType = new XAttribute("value-type", "string");
            XNamespace valTypeNamespace = "urn:oasis:names:tc:opendocument:xmlns:office:1.0";
            XNamespace calcextNamespace = "urn:org:documentfoundation:names:experimental:calc:xmlns:calcext:1.0";

            cell.SetAttributeValue(valTypeNamespace + "value-type", "string");
            cell.SetAttributeValue(calcextNamespace + "value-type", "string");
            cell.Add(InitText(value));

            return cell;
        }


        /// <summary>
        /// Initializes text element of the cell
        /// </summary>
        /// <param name="value">Value of the element</param>
        /// <returns>Initialized text element</returns>
        private XElement InitText(string value)
        {
            XNamespace textNamespace = "urn:oasis:names:tc:opendocument:xmlns:text:1.0";
            var textElement = new XElement(textNamespace + "p")
            {
                Value = value
            };
            return textElement;
        }



        /// <summary>
        /// Adds new row to the XML document
        /// </summary>
        /// <param name="table">table element</param>
        private void AddRow(XElement table)
        {
            XNamespace rowNamespace = "urn:oasis:names:tc:opendocument:xmlns:table:1.0";
            var newRow = new XElement(rowNamespace + "table-row");
            newRow.SetAttributeValue(rowNamespace + "style-name", "ro" + RowCount);
            table.Add(newRow);
            RowCount++;
        }

        
        /// <summary>
        /// Projects invoice details to the XML document
        /// </summary
        /// <param name="table">Table element</param>
        private void FillInvoicedGoodsTable(Invoice invoice, XElement table)
        {
            AddRow(table);
            var result = (from item in invoice.InvoicedItems
                          group item by new { item.Name, item.Cost } into g
                          select new { g.Key.Name, Price = g.Key.Cost, Quantity = g.ToList().Count() })
                         .ToList();

            AddRow(table);
            var tenthRow = table.Elements().ToList().ElementAt(10);

            tenthRow.Add(InitCell("Quantity"));
            tenthRow.Add(InitCell("Product name"));
            tenthRow.Add(InitCell("Unit price"));
            tenthRow.Add(InitCell("Line total"));

            for (int i = 0; i < result.Count; i++)
            {
                AddRow(table);
                var currentRow = table.Elements().ToList().ElementAt(i + 11);
                currentRow.Add(InitCell(result.ElementAt(i).Quantity.ToString()));
                currentRow.Add(InitCell(result.ElementAt(i).Name));
                currentRow.Add(InitCell(result.ElementAt(i).Price.ToString()));
                decimal subTotalSum = result.ElementAt(i).Quantity * result.ElementAt(i).Price;
                currentRow.Add(InitCell(subTotalSum.ToString()));
            }
        }
    }
}
