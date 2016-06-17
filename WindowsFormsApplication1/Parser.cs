using System;   //Using Uri and Exeption.

namespace WebCrawler
{
    /// <summary>
    /// Parsing links class.
    /// </summary>
    class Parser
    {
        /// <summary>
        /// Method to parse the base uri.
        /// </summary>
        /// <param name="base_uri"> The first uri which the user needs to crawl. </param>
        public static void Parsing(Uri base_uri)
        {
            try
            {
                Data.Different_Found_Links_Hash_Set.Add(base_uri);    //Adding the uri to the set of found uris.
                Data.Found_Links_Queue.Enqueue(base_uri);  //Adding the uri to the queue of found uris.
                Data.Not_Crawled_Links_Queue.Enqueue(base_uri);    //Adding the uri to the uris that still not crawled.
                ++Data.Number_Of_Found_Links;   //Increment the number of found uris by a unit.

                //Crawling all uris which still not crawled sequencially.
                while (Data.Not_Crawled_Links_Queue.Count > 0)
                {
                    try
                    {
                        Downloader.Creat_TXT_File(Data.Not_Crawled_Links_Queue.Peek());
                    }

                    catch
                    {
                        //Do nothing.
                    }

                    try
                    {
                        Data.Crawling_Uri = Data.Not_Crawled_Links_Queue.Peek();
                        Fetcher.Fetching(Data.Not_Crawled_Links_Queue.Peek()); //Fetching the first uri in the queue of uris which not yet crawled.
                        Data.Not_Crawled_Links_Queue.Dequeue(); //Delete the uri from the queue.
                    }

                    catch   //Preventing multi threads from accessing the same thing.
                    {
                        //Do nothing.
                    }
                }
            }

            catch (Exception Error)
            {
                Data.Found_Errors_Queue.Enqueue(Error.Message);
                ++Data.Number_Of_Found_Errors;
            }
        }
    }
}