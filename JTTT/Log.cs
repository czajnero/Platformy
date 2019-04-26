using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace JTTT
{
    class Log
    {
        public void log(String message)
        {
            DateTime time = DateTime.Now;
            String outputFile = "jttt.log";

            if (!File.Exists(outputFile))
            {
                FileStream file = File.Create(outputFile);
                file.Close();
            }

            StreamWriter writer = File.AppendText(outputFile);
            writer.WriteLine(time.ToString("[MM/dd/yyyy H:mm:ss]") + "   " + message);
            writer.Flush();
            writer.Close();
        }
    }
}
