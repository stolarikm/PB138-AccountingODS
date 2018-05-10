using System;
using System.IO;
using System.Reflection;
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
            var serializer = new ODSSerializer();
            serializer.ExctractXmlFromODS(Paths.InputFolderPath + "odsToExtract.ods", Paths.OutputFolderPath);
            serializer.InsertXmlToODS(Paths.InputFolderPath, Paths.OutputFolderPath);
            */
        }
    }
}
