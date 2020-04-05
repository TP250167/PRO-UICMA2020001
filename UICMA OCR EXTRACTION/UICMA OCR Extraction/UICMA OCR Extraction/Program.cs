using System;
using System.Configuration;
using System.IO;

namespace UICMA_OCR_Extraction
{
    class Program
    {
        static bool isProcess = false;
        static void Main(string[] args)
        {
            System.Threading.Timer t = new System.Threading.Timer(TimerCallback, null, 100, Convert.ToInt32(ConfigurationManager.AppSettings["RecurranceTime"]));  // 86,400,000  60000
            Console.ReadLine();

            if (!isProcess)
            {
                isProcess = true;
                Console.WriteLine("OCR Extraction Console Application: " + DateTime.Now);
                writeToConsole("------------------------------------------------------------------");

                ProcessOCRExtraction();
                GC.Collect();
                isProcess = false;
            }
        }
        private static void TimerCallback(Object o)
        {
            if (!isProcess)
            {
                isProcess = true;
                writeToConsole("OCR Extraction Start: " + DateTime.Now);
                writeToConsole("------------------------------------------------------------------");
                string getTime = DateTime.Now.ToString("HH:mm");
                ProcessOCRExtraction();
                GC.Collect();
                isProcess = false;
            }
        }
        static private void writeToConsole(string msg, bool isDate = false, bool toFile = false)
        {
            if (isDate)
            {
                Console.Write(" " + DateTime.Now.ToString() + " -> " + msg);
                if (toFile)
                    File.AppendAllText(ConfigurationManager.AppSettings["AuditLog"].ToString() + "MPLog" + DateTime.Now.ToString("yyyyMMdd") + ".txt", " " + DateTime.Now.ToString() + " -> " + msg + Environment.NewLine);
            }
            else
            {
                Console.Write(" " + msg);
                if (toFile)
                    File.AppendAllText(ConfigurationManager.AppSettings["AuditLog"].ToString() + "MPLog" + DateTime.Now.ToString("yyyyMMdd") + ".txt", msg + Environment.NewLine);
            }
            Console.WriteLine();
        }
     static  private  void ProcessOCRExtraction()
        {
            
            OCRExtraction ocrExtraction =new OCRExtraction(ConfigurationManager.AppSettings["ConnectionString"].ToString());
            ocrExtraction.OCRExtractionJob();
            writeToConsole("OCR Extraction End: " + DateTime.Now);
        }
    }
}
