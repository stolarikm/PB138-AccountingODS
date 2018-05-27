using System;
using System.Data;
using System.IO;
using System.Reflection;
using System.Xml;
using AccountingODS.Serialization;
using Ionic.Zip;

namespace AccountingODS
{
    public class OdsWrapper
    {
        private const string CONTENT = "content.xml";

        /// <summary>
        /// Exctracts the content.xml file from ods document.
        /// Extracted xml named content.xml will be stored in ouputPath directory. 
        /// </summary>
        /// <param name="pathToODS">Path to ods including filename</param>
        /// <param name="outputPath">Output path with file named content.xml</param>
        public void ExctractXmlFromODS(string pathToODS, string outputPath)
        {
            XmlDocument document = GetContentXmlFile(GetZipFile(pathToODS));
            SaveXmlFlie(document, outputPath);
        }

        /// <summary>
        /// Inserts the content.xml file to the ods document.
        /// File must be named content.xml, and must be stored in pathToXml directory.
        /// OutputPath must be provided including wanted filename.
        /// </summary>
        /// <param name="pathToXml">Path to xml with file named content.xml</param>
        /// <param name="outputPath">Output path includig filename</param>
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
            ZipEntry contentZipEntry = zipFile[CONTENT];

            Stream contentStream = new MemoryStream();
            contentZipEntry.Extract(contentStream);
            contentStream.Seek(0, SeekOrigin.Begin);

            XmlDocument contentXml = new XmlDocument();
            contentXml.Load(contentStream);
			zipFile.Dispose();

            return contentXml;
        }

        private void SaveXmlFlie(XmlDocument file, string path)
        {
            file.Save(path + CONTENT);
        }


        private ZipFile AddXmlToOds(string pathToXml, ZipFile ods, string outputPath)
        {
            ods.RemoveEntry(ods[CONTENT]);
            ods.AddFile(pathToXml + CONTENT, "");

            return ods;
        }

        private void SaveODSFile(ZipFile odsDocument, string outputPath)
        {
            string filename = outputPath;
            odsDocument.Save(filename);
        }

        private ZipFile GetTemplateODS()
        {
            return GetZipFile(Paths.InputFolderPath + "template.ods");
        }
    }
}
