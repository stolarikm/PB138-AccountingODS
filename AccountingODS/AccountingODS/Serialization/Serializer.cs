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
        public Invoice Invoice { get; private set; }
        public int RowCount { get; private set; } = 3;
        public int ColumnCount { get; private set; } = 3;

        public Serializer(Invoice invoice)
        {
            Invoice = invoice;
        }



        public void Serialize()
        {
            XDocument doc = XDocument.Load(Paths.InputFolderPath + Path.DirectorySeparatorChar + "content.xml");
            var root = doc.Root;

            var table = root.Descendants()
                        .Where(element => element.Name.LocalName == "table")
                        .First();

            PrepareTable(table);
            FillTable(table);

            doc.Save(Paths.OutputFolderPath + "content.xml");
            var wrapper = new OdsWrapper();
            wrapper.InsertXmlToODS(Paths.OutputFolderPath, Paths.OutputFolderPath + "Invoice" + Invoice.InvoiceNumber + ".ods");
        }


        /// <summary>
        /// Fills the table with all necessary data
        /// </summary>
        /// <param name="table"></param>
        private void FillTable(XElement table)
        {
            FillInvoiceHeader(GetNthRow(table, 1));
            FillSecondRow(GetNthRow(table, 2));
            FillThirdRow(GetNthRow(table, 3));
            FillFourthRow(GetNthRow(table, 4));
            FillInfoOfInvolvedPeople(GetNthRow(table, 5), GetNthRow(table, 6), GetNthRow(table, 7));
            FillInvoicedGoodsTable(table);
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
        private void FillSecondRow(XElement secondRow)
        {
            var firstCell = secondRow.Elements().First();
            firstCell.Elements()
                .First()
                .SetValue("Invoice date:");

            secondRow.Elements().ElementAt(1).Remove();
            secondRow.Add(InitCell(Invoice.InvoiceDate.Date.ToString("dd/MM/yyyy")));
            secondRow.Add(InitCell(""));

            secondRow.Add(InitCell("Type:"));
            secondRow.Add(InitCell(Invoice.Type.ToString()));
        }


        /// <summary>
        /// Fills the third row of the table
        /// </summary>
        /// <param name="thirdRow">Third row element</param>
        private void FillThirdRow(XElement thirdRow)
        {
            thirdRow.Add(InitCell("Payment due by:"));
            thirdRow.Add(InitCell(Invoice.MaturityDate.Date.ToString("dd/MM/yyyy")));

            decimal sum = Invoice.InvoicedItems.Sum(item => item.Cost);
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
        private void FillInfoOfInvolvedPeople(XElement fifthRow, XElement sixthRow, XElement seventhRow)
        {
            fifthRow.Add(InitCell(Invoice.Creditor.FullName));
            AddEmptyCells(fifthRow);
            fifthRow.Add(InitCell(Invoice.Debtor.FullName));

            sixthRow.Add(InitCell(Invoice.Creditor.Adress));
            AddEmptyCells(sixthRow);
            sixthRow.Add(InitCell(Invoice.Debtor.Adress));

            seventhRow.Add(InitCell(Invoice.Creditor.ZIPCode));
            AddEmptyCells(seventhRow);
            seventhRow.Add(InitCell(Invoice.Debtor.ZIPCode));
        }


        /// <summary>
        /// Fills first row of the XML invoice
        /// </summary>
        /// <param name="table">Table Element</param>
        private void FillInvoiceHeader(XElement firstRow)
        {
            var test = firstRow.Elements();

            var firstCellText = firstRow.Elements()
                                .Elements()
                                .First();
            firstCellText.Value = "Invoice";

            firstRow.Elements()
                .ToList()
                .ElementAt(1)
                .Elements()
                .First().Value = Invoice.InvoiceNumber;

        }


        private void PrepareTable(XElement table)
        {
            for (int j = 0; j < 5; j++)
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
        private void FillInvoicedGoodsTable(XElement table)
        {
            AddRow(table);
            var result = (from item in Invoice.InvoicedItems
                          group item by new { item.Name, item.Cost } into g
                          select new { g.Key.Name, Price = g.Key.Cost, Quantity = g.ToList().Count() })
                         .ToList();

            AddRow(table);
            AddRow(table);
            var tenthRow = table.Elements().ToList().ElementAt(11);

            tenthRow.Add(InitCell("Quantity"));
            tenthRow.Add(InitCell("Product name"));
            tenthRow.Add(InitCell("Unit price"));
            tenthRow.Add(InitCell("Line total"));

            for (int i = 0; i < result.Count; i++)
            {
                AddRow(table);
                var currentRow = table.Elements().ToList().ElementAt(i + 12);
                currentRow.Add(InitCell(result.ElementAt(i).Quantity.ToString()));
                currentRow.Add(InitCell(result.ElementAt(i).Name));
                currentRow.Add(InitCell(result.ElementAt(i).Price.ToString()));
                decimal subTotalSum = result.ElementAt(i).Quantity * result.ElementAt(i).Price;
                currentRow.Add(InitCell(subTotalSum.ToString()));
            }
        }


    }
}
