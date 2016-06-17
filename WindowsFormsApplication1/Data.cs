using System;   //Using Uri.
using System.Collections.Generic;   //Using Queue and HashSet.
using System.Threading; //using Thread.

namespace WebCrawler
{
    /// <summary>
    /// Project main data.
    /// </summary>
    class Data
    {
        #region Containers
        #region Hash sets
        public static HashSet<Uri> Different_Found_Links_Hash_Set;
        #endregion

        #region Queues
        public static Queue<Uri> Crawled_Links_Queue;
        public static Queue<Uri> Found_Links_Queue;
        public static Queue<Uri> Not_Crawled_Links_Queue;
        public static Queue<string> Found_Errors_Queue;
        #endregion

        #region Uris
        public static Uri Base_Uri;
        public static Uri Crawling_Uri;
        #endregion

        #region Strings.
        public static string Available_Ram_String;
        public static string Corpus_Path_String;
        public static string Cpu_Usage_String;
        #endregion
        #endregion
        

        #region Threads
        public static Thread Parsing_Thread1;
        public static Thread Parsing_Thread2;
        public static Thread Parsing_Thread3;
        public static Thread Loading_Picture_Thread;
        public static Thread Printing_Links_Thread;
        public static Thread Helper;
        #endregion
        

        #region Counters
        #region Links
        public static int Number_Of_Crawled_Links;
        public static int Number_Of_Downloaded_Links;
        public static int Number_Of_Found_Links;
        #endregion

        #region Errors
        public static int Number_Of_Found_Errors;
        #endregion

        #region Time
        public static int Hours;
        public static int Minutes;
        public static int Seconds;
        public static int Waiting;
        #endregion
        #endregion

        
        #region Flags
        public static bool Internet_Flag;
        #endregion
        

        /// <summary>
        /// Method to Initialize class Component.
        /// </summary>
        public static void InitializeComponent()
        {
            #region Containers
            #region Hash sets
            Different_Found_Links_Hash_Set = new HashSet<Uri>();
            #endregion

            #region Queues
            Crawled_Links_Queue = new Queue<Uri>();
            Found_Errors_Queue = new Queue<string>();
            Found_Links_Queue = new Queue<Uri>();
            Not_Crawled_Links_Queue = new Queue<Uri>();
            #endregion

            #region Uris
            Base_Uri = null;
            Crawling_Uri = null;
            #endregion
            #endregion
            

            #region Counters
            #region Links
            Number_Of_Crawled_Links = 0;
            Number_Of_Downloaded_Links = 0;
            Number_Of_Found_Links = 0;
            #endregion

            #region Errors
            Number_Of_Found_Errors = 0;
            #endregion

            #region Time
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
            Waiting = 0;
            #endregion
            #endregion
            

            #region Strings
            Corpus_Path_String = string.Empty;
            #endregion
            

            #region Flags
            Internet_Flag = false;
            #endregion
        }
    }
}