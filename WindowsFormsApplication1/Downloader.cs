using System;   //Using Uri.
using System.IO;    //Using StreamWriter.

namespace WebCrawler
{
    /// <summary>
    /// Downloading uris class.
    /// </summary>
    class Downloader
    {
        /// <summary>
        /// Creating folder method.
        /// </summary>
        /// <param name="path"> Folder path. </param>
        /// <param name="folderName"> Folder name. </param>
        public static void Creat_Folder(string path, Uri folderName)
        {
            string newPath = System.IO.Path.Combine(path, folderName.Host);
            System.IO.Directory.CreateDirectory(newPath);
        }

        /// <summary>
        /// Creating file method.
        /// </summary>
        /// <param name="uri"> Crawled uri. </param>
        public static void Creat_TXT_File(Uri uri)
        {
            string Cleared_Name = Clear(uri.Host);
            string newPath = Path.Combine(Data.Corpus_Path_String, Data.Base_Uri.Host, (Data.Number_Of_Crawled_Links + 1).ToString() + ") " + Cleared_Name + ".txt");
            TXT_File = new StreamWriter(newPath);
            TXT_File.WriteLine(uri.ToString());
        }

        /// <summary>
        /// Delete characters which must be deleted from a file name.
        /// </summary>
        /// <param name="Name"> File name to be cleared. </param>
        /// <returns> Cleared file name. </returns>
        private static string Clear(string Name)
        {
            string ClearName = "";

            for (int i = 0; i < Name.Length; ++i)
            {
                if (Name[i] != '\\' && Name[i] != '/' && Name[i] != '*' && Name[i] != ':' && Name[i] != '|'
                    && Name[i] != '?' && Name[i] != '؟' && Name[i] != '>' && Name[i] != '<')
                {
                    ClearName += Name[i];
                }
            }

            return ClearName;
        }

        public static StreamWriter TXT_File;
    }
}