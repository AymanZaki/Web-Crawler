using System; //Using Uri and Exeption.
using HtmlAgilityPack;  //Using HtmlWeb, HtmlDocument, HtmlNodeCollection and HtmlNode.

namespace WebCrawler
{
    /// <summary>
    /// Fetching uris class.
    /// </summary>
    class Fetcher
    {
        /// <summary>
        /// Method to fetch uri.
        /// </summary>
        /// <param name="uri"> The uri which needed to be fetched. </param>
        public static void Fetching(Uri uri)
        {
            ++Data.Number_Of_Crawled_Links; //Increment the number of crawled uris by a unit.

            try
            {
                HtmlWeb htmlweb = new HtmlWeb();
                HtmlDocument document = htmlweb.Load(uri.ToString());
                HtmlNodeCollection hrefs = document.DocumentNode.SelectNodes("//a[@href]");

                if (hrefs == null)
                {
                    return;
                }

                //Extracting links.
                foreach (HtmlNode href in hrefs)
                {
                    try
                    {
                        Uri temp_uri;
                        string value = href.Attributes["href"].Value;
                        temp_uri = new Uri(Data.Base_Uri, value);

                        //Check if the temp uri is valid and not found before.
                        if (value != null && Data.Different_Found_Links_Hash_Set.Contains(temp_uri) == false)
                        {
                            Data.Different_Found_Links_Hash_Set.Add(temp_uri);    //Adding the uri to the set of found uris.
                            Data.Found_Links_Queue.Enqueue(temp_uri);  //Adding the uri to the queue of found uriss.
                            Data.Not_Crawled_Links_Queue.Enqueue(temp_uri);    //Adding the uri to the uris that still not crawled.
                            ++Data.Number_Of_Found_Links;   //Increment the number of found uris by a unit.

                            try
                            {
                                Downloader.TXT_File.WriteLine(temp_uri);    //Adding the uri to its parent uri file.
                                ++Data.Number_Of_Downloaded_Links;  //Increment the number of downloaded uris by a unit.
                            }

                            catch (Exception Error)
                            {
                                Data.Found_Errors_Queue.Enqueue(Error.Message);
                                ++Data.Number_Of_Found_Errors;
                            }
                        }
                    }

                    catch (Exception Error)
                    {
                        Data.Found_Errors_Queue.Enqueue(Error.Message);
                        ++Data.Number_Of_Found_Errors;
                    }
                }

                Data.Not_Crawled_Links_Queue.Dequeue(); //Deleting the uri which has already crawled from the queue of found uris.
                Data.Crawled_Links_Queue.Enqueue(uri); //Adding the uri to the queue of the crawled uris.
            }

            catch (Exception Error)
            {
                Data.Found_Errors_Queue.Enqueue(Error.Message);
                ++Data.Number_Of_Found_Errors;
            }
        }
    }
}