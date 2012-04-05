using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplicationTestUnitaire.DataAccess
{
    public class LogMe
    {
        public static void Log(Exception ex)
        {
            string path ="log";
            string name = DateTime.Today.ToShortDateString().Replace('/', '_');
            StreamWriter sw = new StreamWriter(path + "/" + name + ".log", true);
            sw.WriteLine(sw.NewLine);
            sw.WriteLine(DateTime.Now + " ==> " + ex.Message);
            sw.Flush();
            sw.Close();
        }
    }
}
