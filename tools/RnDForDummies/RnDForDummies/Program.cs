using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml;
using System.IO;

namespace RnDForDummies
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Dictionary<string, ResearchLevel> items = new Dictionary<string, ResearchLevel>();
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            string line;
			// Read the file and display it line by line.
			//File.SetAttributes(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Application.ExecutablePath + "\\ResearchLevels.txt")))), FileAttributes.Normal);
			System.IO.StreamReader file = new System.IO.StreamReader(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Application.ExecutablePath + "\\ResearchLevels.txt")))));
            while ((line = file.ReadLine()) != null)
            {
                items.Add(line.Trim(), new ResearchLevel(file.ReadLine()));
            }
            file.Close();
            string JsonString = JsonConvert.SerializeObject(items, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(Application.ExecutablePath, JsonString);

            var a = JsonConvert.SerializeObject(items.ToArray());
            XmlDocument xmlDocument = new XmlDocument();
            
            file.Close();
        }
    }
}