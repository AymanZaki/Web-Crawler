using System;   //using STAThread.
using System.Windows.Forms; //Using Application.

namespace WebCrawler
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] //Indicates that the COM threading model for an application is single-threaded apartment (STA).
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Web_Crawler());
        }
    }
}