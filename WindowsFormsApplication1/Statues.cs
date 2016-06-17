using System.Diagnostics;   //Using PerformanceCounter.
using System.Net;   //Using IPHostEntry.

namespace WebCrawler
{
    class Statues
    {
        /// <summary>
        /// Checking internet network.
        /// </summary>
        public static void Check_Internet()
        {
            try
            {
                IPHostEntry IP = Dns.GetHostEntry("www.google.com"); //Sending request to google.
                Data.Internet_Flag = true;
            }
            catch
            {
                Data.Internet_Flag = false;
            }
        }

        /// <summary>
        /// Getting CPU current usage.
        /// </summary>
        public static void Cpu()
        {
            PerformanceCounter CPU = new PerformanceCounter();
            CPU = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            dynamic firstValue = CPU.NextValue();
            System.Threading.Thread.Sleep(100);
            Data.Cpu_Usage_String = CPU.NextValue().ToString();
        }

        /// <summary>
        /// Getting current availabel RAM.
        /// </summary>
        public static void Ram()
        {
            PerformanceCounter RAM;
            RAM = new PerformanceCounter("Memory", "Available MBytes", true);
            Data.Available_Ram_String = RAM.NextValue().ToString();
        }
    }
}