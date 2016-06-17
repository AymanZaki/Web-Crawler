using System;   //using Thread, EventArgs, Uri and Exeption.
using System.Drawing; //Using Image abstract base class.
using System.Threading; //Using Thread.
using System.Windows.Forms; //Using class.

namespace WebCrawler
{
    /// <summary>
    /// Form1 Application.
    /// </summary>
    public partial class Web_Crawler : Form   //Represents a window or dialog box that makes up an application's user interface.
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Web_Crawler()
        {
            InitializeComponent();
            Pause_And_Continue_Button.Enabled = false;  //User can't control the button.
            Stop_Button.Enabled = false;    //User can't control the button.
            Timer_Timer.Enabled = false;    //Crawl processing still not started yet.
        }


        /// <summary>
        /// Browse button job.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Browse_Button_Click(object sender, EventArgs e)
        {
            //Browsing the path at which the folder would be stored.
            if (Browse_Link_FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                User_path_Text_Box.Text = Browse_Link_FolderBrowserDialog.SelectedPath.ToString();
            }
        }


        /// <summary>
        /// Closing Application method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Closing_Application(object sender, FormClosingEventArgs e)
        {
            //Aborting threads before closing.
            if (Crawl_Button.Enabled == false)
            {
                Thread t = new Thread(() => Stop_Crawling());
                t.Start();
            }
        }


        /// <summary>
        /// Crawl button job.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Crawl_Button_Click(object sender, EventArgs e)
        {
            Start_Crawling();
        }


        /// <summary>
        /// Loading pictures while crawling links.
        /// </summary>
        private void Loading()
        {
            while (true)
            {
                Loading_Picture_Box.BackgroundImage = Image.FromFile(Resources.Loading_Picture1);   //Loading the first one.

                Statues.Cpu();
                Statues.Ram();

                Loading_Picture_Box.BackgroundImage = Image.FromFile(Resources.Loading_Picture2);   //Loading the second one.

                Statues.Cpu();
                Statues.Ram();

                Loading_Picture_Box.BackgroundImage = Image.FromFile(Resources.Loading_Picture3);   //Loading the third one.

                Statues.Cpu();
                Statues.Ram();

            }
            /* The sleeping statements are required to notice the change between the three pictures.
               And that is being done in each "Statues.Cpu();" calling statement. */
        }


        /// <summary>
        /// Pause and continue button job.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pause_And_Continue_Button_Click(object sender, EventArgs e)
        {
            Pause_And_Continue_Crawling();
        }


        /// <summary>
        /// Pause and continue crawling method.
        /// </summary>
        private void Pause_And_Continue_Crawling()
        {
            try
            {
                //Pause button job.
                if (Pause_And_Continue_Button.Text == "Pause")
                {
                    try
                    {
                        Data.Loading_Picture_Thread.Suspend();
                        Data.Printing_Links_Thread.Suspend();
                        Data.Parsing_Thread1.Suspend();
                        Data.Parsing_Thread2.Suspend();
                        Data.Parsing_Thread3.Suspend();
                        Data.Helper.Suspend();
                    }

                    catch
                    {
                        //Do nothing.
                    }

                    Availabel_RAM_Value_Label.Text = "None";    //User can't see RAm statues.
                    CPU_Usage_Value_Label.Text = "None";    //User can't see CPU statues.
                    Crawling_URL_Link_Label.Text = "None";
                    Timer_Timer.Enabled = false;
                    Pause_And_Continue_Button.Text = "Continue";
                }

                //Continue button job.
                else
                {
                    try
                    {
                        Data.Loading_Picture_Thread.Resume();
                        Data.Printing_Links_Thread.Resume();
                        Data.Parsing_Thread1.Resume();
                        Data.Parsing_Thread2.Resume();
                        Data.Parsing_Thread3.Resume();
                        Data.Helper.Resume();
                    }

                    catch
                    {
                        //Do nothing
                    }

                    Timer_Timer.Enabled = true;
                    Pause_And_Continue_Button.Text = "Pause";
                }
            }

            catch (Exception Error)
            {
                Data.Found_Errors_Queue.Enqueue(Error.Message);
                ++Data.Number_Of_Found_Errors;
            }
        }


        /// <summary>
        /// Printing links to user.
        /// </summary>
        private void Printing_Links()
        {
            while (true)
            {
                try
                {
                    Crawling_URL_Link_Label.Text = Data.Crawling_Uri.ToString();
                }

                catch   //Preventing multi threads from accessing the same thing.
                {
                    //Do nothing.
                }

                try
                {
                    Found_Links_List_Box.Items.Add(Data.Found_Links_Queue.Peek().ToString());

                    Data.Found_Links_Queue.Dequeue();
                }

                catch   //Preventing dequeue statement if the queue is empty.
                {
                    //Do nothing.
                }

                try
                {
                    Found_Errors_List_Box.Items.Add(Data.Found_Errors_Queue.Peek().ToString());

                    Data.Found_Errors_Queue.Dequeue();
                }

                catch   //Preventing dequeue statement if the queue is empty.
                {
                    //Do nothing.
                }

                try
                {
                    Availabel_RAM_Value_Label.Text = Data.Available_Ram_String + " MB";
                    CPU_Usage_Value_Label.Text = Data.Cpu_Usage_String + "%";
                    Crawled_Links_Value_Label.Text = Data.Number_Of_Crawled_Links.ToString();
                    Downloaded_Links_Value_Label.Text = Data.Number_Of_Downloaded_Links.ToString();
                    Found_Errors_Value_Label.Text = Data.Number_Of_Found_Errors.ToString();
                    Found_Links_Value_Label.Text = Data.Number_Of_Found_Links.ToString();
                    Internet_Access_Value_Label.Text = Data.Internet_Flag.ToString();
                    Found_Errors_List_Box.SelectedIndex = Found_Errors_List_Box.Items.Count - 1;
                    Found_Links_List_Box.SelectedIndex = Found_Links_List_Box.Items.Count - 1;
                }

                catch   //Preventing multi threads from accessing the same thing.
                {
                    //Do nothing.
                }

                if (Data.Number_Of_Crawled_Links == Data.Number_Of_Found_Links)
                {
                    ++Data.Waiting;

                    if (Data.Waiting == 10000)
                    {
                        //Terminate.
                        Thread t = new Thread(() => Stop_Crawling());
                        t.Start();

                        Data.Waiting = 0;
                    }
                }

                Statues.Check_Internet();
                Internet_Access_Value_Label.Text = Data.Internet_Flag.ToString();
            }
        }


        /// <summary>
        /// Crawling method.
        /// </summary>
        private void Start_Crawling()
        {
            Uri uri;
            try
            {
                Statues.Check_Internet();

                if (Data.Internet_Flag == false)
                {
                    Internet_Access_Value_Label.Text = "False";
                    Data.Found_Errors_Queue.Enqueue("There is no internet access.");
                    ++Data.Number_Of_Found_Errors;
                    return;
                }

                Internet_Access_Value_Label.Text = "True";
                User_Link_Text_Box.Focus(); //Setting the uri written by the user to the control.

                //Checking if the user didn't enter a link or not.
                if (User_Link_Text_Box.Text == "" || User_Link_Text_Box.Text == "Ex:http://www.example.com")
                {
                    User_Link_Text_Box.Text = "https://www.google.com"; //Default uri.
                }

                uri = new Uri(User_Link_Text_Box.Text);

                Data.InitializeComponent(); //Initializing Data class components.
                Data.Corpus_Path_String = User_path_Text_Box.Text;

                //Default path.
                if (Data.Corpus_Path_String == string.Empty)
                {
                    User_path_Text_Box.Text = @"C:\Corpus";
                    Data.Corpus_Path_String = @"C:\Corpus";
                }
            }

            catch (Exception Error)
            {
                Data.Found_Errors_Queue.Enqueue(Error.Message);
                ++Data.Number_Of_Found_Errors;
                return;
            }

            try
            {
                Found_Links_List_Box.Items.Add(uri.ToString());

                #region Initializing uris
                Data.Base_Uri = new Uri(User_Link_Text_Box.Text); //Setting base uri with the uri written by user.
                Data.Crawling_Uri = new Uri(Data.Base_Uri.ToString());  //Setting crawling uri with the uri written by user.
                #endregion

                #region Initializing threads
                Data.Parsing_Thread1 = new Thread(() => Parser.Parsing(uri));
                Data.Parsing_Thread2 = new Thread(() => Parser.Parsing(uri));
                Data.Parsing_Thread3 = new Thread(() => Parser.Parsing(uri));
                Data.Loading_Picture_Thread = new Thread(() => Loading());
                Data.Printing_Links_Thread = new Thread(() => Printing_Links());
                Data.Helper = new Thread(() => Handling_Multithreading());
                #endregion

                #region User controls
                Browse_Button.Enabled = false;  //User can't control the button.
                Crawl_Button.Enabled = false;   //User can't control the button.
                Pause_And_Continue_Button.Enabled = true;   //User can control the button.
                Stop_Button.Enabled = true; //User can control the button.
                User_Link_Text_Box.Enabled = false; //User can't control the text box.
                User_path_Text_Box.Enabled = false; //User can't control the text box.
                #endregion

                #region User statistics
                Crawled_Links_Value_Label.Text = "0";
                Found_Errors_Value_Label.Text = "0";
                Found_Links_Value_Label.Text = "0";
                Time_Value_Label.Text = "00:00:00";
                #endregion

                #region Corpus folder
                Downloader.Creat_Folder(Data.Corpus_Path_String, Data.Base_Uri);   //Creating folder to save links.
                #endregion

                #region Clearing list boxes
                Found_Errors_List_Box.Items.Clear();
                Found_Links_List_Box.Items.Clear();
                #endregion

                #region starting threads and timers
                Data.Loading_Picture_Thread.Start();
                Data.Parsing_Thread1.Start();
                Data.Parsing_Thread2.Start();
                Data.Parsing_Thread3.Start();
                Data.Printing_Links_Thread.Start();
                Data.Helper.Start();
                Timer_Timer.Start();
                #endregion

            }

            catch (Exception Error)
            {
                Data.Found_Errors_Queue.Enqueue(Error.Message);
                ++Data.Number_Of_Found_Errors;
            }
        }


        /// <summary>
        /// Stop button job.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stop_Button_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Stop_Crawling());
            t.Start();
        }


        /// <summary>
        /// Stop crawling method.
        /// </summary>
        private void Stop_Crawling()
        {
            if (Pause_And_Continue_Button.Text == "Continue")
            {
                Availabel_RAM_Value_Label.Text = Data.Available_Ram_String;
                CPU_Usage_Value_Label.Text = Data.Cpu_Usage_String;
                Pause_And_Continue_Crawling();
            }
            try
            {
                Data.Loading_Picture_Thread.Abort();
                Data.Printing_Links_Thread.Abort();
                Data.Parsing_Thread1.Abort();
                Data.Parsing_Thread2.Abort();
                Data.Parsing_Thread3.Abort();
                Data.Helper.Abort();
                Timer_Timer.Stop();
            }

            catch
            {
                //Do nothing.
            }

            Browse_Button.Enabled = true;   //User can control the button.
            Crawl_Button.Enabled = true;    //User can control the button.
            Pause_And_Continue_Button.Enabled = false;  //User can't control the button.
            Stop_Button.Enabled = false;    //User can't control the button.
            Availabel_RAM_Value_Label.Text = "None";    //User can't see RAm statues.
            CPU_Usage_Value_Label.Text = "None";    //User can't see CPU statues.
            Internet_Access_Value_Label.Text = "None";
            Crawling_URL_Link_Label.Text = "None";
            User_Links_Adding();
            User_Links_List_Box.SelectedIndex = User_Links_List_Box.Items.Count - 1;
            User_Link_Text_Box.Enabled = true;  //User can control the text box.
            User_path_Text_Box.Enabled = true; //User can control the text box.

            Loading_Picture_Box.BackgroundImage = Image.FromFile(Resources.Loading_Picture1);
        }


        /// <summary>
        /// Timer tick method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Timer_Tick(object sender, EventArgs e)
        {
            ++Data.Seconds;

            if (Data.Seconds == 60)
            {
                ++Data.Minutes;
                Data.Seconds = 0;
            }

            if (Data.Minutes == 60)
            {
                ++Data.Hours;
                Data.Minutes = 0;
            }

            Time_Value_Label.Text = "";
            if (Data.Hours < 10)
            {
                Time_Value_Label.Text += "0";
            }

            Time_Value_Label.Text += Data.Hours.ToString();
            Time_Value_Label.Text += ":";

            if (Data.Minutes < 10)
            {
                Time_Value_Label.Text += "0";
            }

            Time_Value_Label.Text += Data.Minutes.ToString();
            Time_Value_Label.Text += ":";

            if (Data.Seconds < 10)
            {
                Time_Value_Label.Text += "0";
            }

            Time_Value_Label.Text += Data.Seconds.ToString();
        }


        /// <summary>
        /// Crawling using pressed key.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void User_Link_Text_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Check if the pressed key is Enter.
            if (e.KeyChar == (char)Keys.Enter)
            {
                Start_Crawling();
            }
        }


        /// <summary>
        /// Each line appeared in user links list box.
        /// </summary>
        private void User_Links_Adding()
        {
            string item = "";
            item += "Local uri : " + Data.Base_Uri.ToString() + "\t\t";
            item += "Found links : " + Data.Number_Of_Found_Links.ToString() + "\t\t";
            item += "Crawled links : " + Data.Number_Of_Crawled_Links.ToString() + "\t\t";
            item += "Downloaded links : " + Data.Number_Of_Downloaded_Links.ToString() + "\t\t";
            item += "Found Error : " + Data.Number_Of_Found_Errors.ToString() + "\t\t";
            item += "Used time : " + Time_Value_Label.Text;
            User_Links_List_Box.Items.Add(item);
        }

        /// <summary>
        /// 
        /// </summary>
        private void Handling_Multithreading()
        {
            for (int i = 0; i < 2; ++i)
            {
                try
                {
                    Found_Links_List_Box.Items.RemoveAt(0);
                    --Data.Number_Of_Found_Links;
                    --Data.Number_Of_Crawled_Links;
                }

                catch
                {
                    --i;
                }
            }
        }
    }
}