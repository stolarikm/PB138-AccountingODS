using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Xml;
using AccountingODS.Serialization;
using Ionic.Zip;

namespace AccountingODS
{
    public class ODSSerializer
    {
        public void ExctractXmlFromODS(string pathToODS, string outputPath)
        {
            XmlDocument document = GetContentXmlFile(GetZipFile(pathToODS));
            SaveXmlFlie(document, outputPath);
        }

        public void InsertXmlToODS(string pathToXml, string outputPath)
        {
            ZipFile odsFile = GetTemplateODS();
            odsFile = AddXmlToOds(pathToXml, odsFile, outputPath);
            SaveODSFile(odsFile, outputPath);
        }

        private ZipFile GetZipFile(Stream stream)
        {
            return ZipFile.Read(stream);
        }

        private ZipFile GetZipFile(string inputFilePath)
        {
            return ZipFile.Read(inputFilePath);
        }

        private XmlDocument GetContentXmlFile(ZipFile zipFile)
        {
            ZipEntry contentZipEntry = zipFile["content.xml"];

            Stream contentStream = new MemoryStream();
            contentZipEntry.Extract(contentStream);
            contentStream.Seek(0, SeekOrigin.Begin);

            XmlDocument contentXml = new XmlDocument();
            contentXml.Load(contentStream);

            return contentXml;
        }

        private void SaveXmlFlie(XmlDocument file, string path)
        {
            file.Save(path + "content.xml");
        }


        private ZipFile AddXmlToOds(string pathToXml, ZipFile ods, string outputPath)
        {
            ods.RemoveEntry(ods["content.xml"]);
            ods.AddFile(pathToXml + "content.xml", "");

            return ods;
        }

        private void SaveODSFile(ZipFile odsDocument, string outputPath)
        {
            string filename = outputPath + "ODSoutput.ods";
            odsDocument.Save(filename);
        }

        private ZipFile GetTemplateODS()
        {
            return GetZipFile(Paths.InputFolderPath + "template.ods");
        }
    }
}
