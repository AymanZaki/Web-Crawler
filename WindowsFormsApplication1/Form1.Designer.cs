namespace WebCrawler
{
    partial class Web_Crawler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Web_Crawler));
            this.Browse_Button = new System.Windows.Forms.Button();
            this.Crawl_Button = new System.Windows.Forms.Button();
            this.Pause_And_Continue_Button = new System.Windows.Forms.Button();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.Browse_Link_FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.Statistics_GroupBox = new System.Windows.Forms.GroupBox();
            this.Internet_Access_Value_Label = new System.Windows.Forms.Label();
            this.Internet_Access_Label = new System.Windows.Forms.Label();
            this.Downloaded_Links_Value_Label = new System.Windows.Forms.Label();
            this.Downloaded_Links_Label = new System.Windows.Forms.Label();
            this.Availabel_RAM_Value_Label = new System.Windows.Forms.Label();
            this.CPU_Usage_Value_Label = new System.Windows.Forms.Label();
            this.Available_RAM_Label = new System.Windows.Forms.Label();
            this.CPU_Usage_Label = new System.Windows.Forms.Label();
            this.Time_Value_Label = new System.Windows.Forms.Label();
            this.Time_Label = new System.Windows.Forms.Label();
            this.Found_Errors_Value_Label = new System.Windows.Forms.Label();
            this.Crawled_Links_Value_Label = new System.Windows.Forms.Label();
            this.Found_Links_Value_Label = new System.Windows.Forms.Label();
            this.Found_Errors_Label = new System.Windows.Forms.Label();
            this.Crawled_Links_Label = new System.Windows.Forms.Label();
            this.Found_Links_Label = new System.Windows.Forms.Label();
            this.Crawling_Link_Label = new System.Windows.Forms.Label();
            this.Local_URL_Label = new System.Windows.Forms.Label();
            this.Crawling_URL_Link_Label = new System.Windows.Forms.LinkLabel();
            this.Found_Errors_List_Box = new System.Windows.Forms.ListBox();
            this.Found_Links_List_Box = new System.Windows.Forms.ListBox();
            this.User_Links_List_Box = new System.Windows.Forms.ListBox();
            this.Application_Picture_Box = new System.Windows.Forms.PictureBox();
            this.Loading_Picture_Box = new System.Windows.Forms.PictureBox();
            this.Results_Tab_Control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.User_Link_Text_Box = new System.Windows.Forms.TextBox();
            this.User_path_Text_Box = new System.Windows.Forms.TextBox();
            this.Timer_Timer = new System.Windows.Forms.Timer(this.components);
            this.Statistics_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Application_Picture_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loading_Picture_Box)).BeginInit();
            this.Results_Tab_Control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Browse_Button
            // 
            this.Browse_Button.BackColor = System.Drawing.Color.Blue;
            this.Browse_Button.FlatAppearance.BorderSize = 0;
            this.Browse_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Browse_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Browse_Button.Location = new System.Drawing.Point(520, 139);
            this.Browse_Button.Name = "Browse_Button";
            this.Browse_Button.Size = new System.Drawing.Size(75, 25);
            this.Browse_Button.TabIndex = 11;
            this.Browse_Button.TabStop = false;
            this.Browse_Button.Text = "Browse";
            this.Browse_Button.UseVisualStyleBackColor = false;
            this.Browse_Button.Click += new System.EventHandler(this.Browse_Button_Click);
            // 
            // Crawl_Button
            // 
            this.Crawl_Button.BackColor = System.Drawing.Color.Green;
            this.Crawl_Button.FlatAppearance.BorderSize = 0;
            this.Crawl_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Crawl_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crawl_Button.ForeColor = System.Drawing.Color.White;
            this.Crawl_Button.Location = new System.Drawing.Point(520, 104);
            this.Crawl_Button.Name = "Crawl_Button";
            this.Crawl_Button.Size = new System.Drawing.Size(75, 25);
            this.Crawl_Button.TabIndex = 2;
            this.Crawl_Button.TabStop = false;
            this.Crawl_Button.Text = "Crawl";
            this.Crawl_Button.UseVisualStyleBackColor = false;
            this.Crawl_Button.Click += new System.EventHandler(this.Crawl_Button_Click);
            // 
            // Pause_And_Continue_Button
            // 
            this.Pause_And_Continue_Button.BackColor = System.Drawing.Color.Goldenrod;
            this.Pause_And_Continue_Button.FlatAppearance.BorderSize = 0;
            this.Pause_And_Continue_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause_And_Continue_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause_And_Continue_Button.ForeColor = System.Drawing.Color.White;
            this.Pause_And_Continue_Button.Location = new System.Drawing.Point(600, 104);
            this.Pause_And_Continue_Button.Name = "Pause_And_Continue_Button";
            this.Pause_And_Continue_Button.Size = new System.Drawing.Size(75, 25);
            this.Pause_And_Continue_Button.TabIndex = 6;
            this.Pause_And_Continue_Button.Text = "Pause";
            this.Pause_And_Continue_Button.UseVisualStyleBackColor = false;
            this.Pause_And_Continue_Button.Click += new System.EventHandler(this.Pause_And_Continue_Button_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.BackColor = System.Drawing.Color.DarkRed;
            this.Stop_Button.FlatAppearance.BorderSize = 0;
            this.Stop_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Stop_Button.Location = new System.Drawing.Point(600, 139);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(75, 25);
            this.Stop_Button.TabIndex = 7;
            this.Stop_Button.Text = "Stop";
            this.Stop_Button.UseVisualStyleBackColor = false;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Statistics_GroupBox
            // 
            this.Statistics_GroupBox.Controls.Add(this.Internet_Access_Value_Label);
            this.Statistics_GroupBox.Controls.Add(this.Internet_Access_Label);
            this.Statistics_GroupBox.Controls.Add(this.Downloaded_Links_Value_Label);
            this.Statistics_GroupBox.Controls.Add(this.Downloaded_Links_Label);
            this.Statistics_GroupBox.Controls.Add(this.Availabel_RAM_Value_Label);
            this.Statistics_GroupBox.Controls.Add(this.CPU_Usage_Value_Label);
            this.Statistics_GroupBox.Controls.Add(this.Available_RAM_Label);
            this.Statistics_GroupBox.Controls.Add(this.CPU_Usage_Label);
            this.Statistics_GroupBox.Controls.Add(this.Time_Value_Label);
            this.Statistics_GroupBox.Controls.Add(this.Time_Label);
            this.Statistics_GroupBox.Controls.Add(this.Found_Errors_Value_Label);
            this.Statistics_GroupBox.Controls.Add(this.Crawled_Links_Value_Label);
            this.Statistics_GroupBox.Controls.Add(this.Found_Links_Value_Label);
            this.Statistics_GroupBox.Controls.Add(this.Found_Errors_Label);
            this.Statistics_GroupBox.Controls.Add(this.Crawled_Links_Label);
            this.Statistics_GroupBox.Controls.Add(this.Found_Links_Label);
            this.Statistics_GroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Statistics_GroupBox.Location = new System.Drawing.Point(733, 80);
            this.Statistics_GroupBox.Name = "Statistics_GroupBox";
            this.Statistics_GroupBox.Size = new System.Drawing.Size(541, 85);
            this.Statistics_GroupBox.TabIndex = 14;
            this.Statistics_GroupBox.TabStop = false;
            this.Statistics_GroupBox.Text = "Statistics";
            // 
            // Internet_Access_Value_Label
            // 
            this.Internet_Access_Value_Label.AutoSize = true;
            this.Internet_Access_Value_Label.Location = new System.Drawing.Point(459, 65);
            this.Internet_Access_Value_Label.Name = "Internet_Access_Value_Label";
            this.Internet_Access_Value_Label.Size = new System.Drawing.Size(33, 13);
            this.Internet_Access_Value_Label.TabIndex = 17;
            this.Internet_Access_Value_Label.Text = "None";
            // 
            // Internet_Access_Label
            // 
            this.Internet_Access_Label.AutoSize = true;
            this.Internet_Access_Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Internet_Access_Label.Location = new System.Drawing.Point(375, 65);
            this.Internet_Access_Label.Name = "Internet_Access_Label";
            this.Internet_Access_Label.Size = new System.Drawing.Size(86, 13);
            this.Internet_Access_Label.TabIndex = 16;
            this.Internet_Access_Label.Text = "Internet access :";
            // 
            // Downloaded_Links_Value_Label
            // 
            this.Downloaded_Links_Value_Label.AutoSize = true;
            this.Downloaded_Links_Value_Label.Location = new System.Drawing.Point(110, 65);
            this.Downloaded_Links_Value_Label.Name = "Downloaded_Links_Value_Label";
            this.Downloaded_Links_Value_Label.Size = new System.Drawing.Size(13, 13);
            this.Downloaded_Links_Value_Label.TabIndex = 15;
            this.Downloaded_Links_Value_Label.Text = "0";
            // 
            // Downloaded_Links_Label
            // 
            this.Downloaded_Links_Label.AutoSize = true;
            this.Downloaded_Links_Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Downloaded_Links_Label.Location = new System.Drawing.Point(5, 65);
            this.Downloaded_Links_Label.Name = "Downloaded_Links_Label";
            this.Downloaded_Links_Label.Size = new System.Drawing.Size(97, 13);
            this.Downloaded_Links_Label.TabIndex = 14;
            this.Downloaded_Links_Label.Text = "Downloaded links :";
            // 
            // Availabel_RAM_Value_Label
            // 
            this.Availabel_RAM_Value_Label.AutoSize = true;
            this.Availabel_RAM_Value_Label.Location = new System.Drawing.Point(459, 21);
            this.Availabel_RAM_Value_Label.Name = "Availabel_RAM_Value_Label";
            this.Availabel_RAM_Value_Label.Size = new System.Drawing.Size(33, 13);
            this.Availabel_RAM_Value_Label.TabIndex = 13;
            this.Availabel_RAM_Value_Label.Text = "None";
            // 
            // CPU_Usage_Value_Label
            // 
            this.CPU_Usage_Value_Label.AutoSize = true;
            this.CPU_Usage_Value_Label.Location = new System.Drawing.Point(459, 43);
            this.CPU_Usage_Value_Label.Name = "CPU_Usage_Value_Label";
            this.CPU_Usage_Value_Label.Size = new System.Drawing.Size(33, 13);
            this.CPU_Usage_Value_Label.TabIndex = 12;
            this.CPU_Usage_Value_Label.Text = "None";
            // 
            // Available_RAM_Label
            // 
            this.Available_RAM_Label.AutoSize = true;
            this.Available_RAM_Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Available_RAM_Label.Location = new System.Drawing.Point(375, 21);
            this.Available_RAM_Label.Name = "Available_RAM_Label";
            this.Available_RAM_Label.Size = new System.Drawing.Size(83, 13);
            this.Available_RAM_Label.TabIndex = 11;
            this.Available_RAM_Label.Text = "Available RAM :";
            // 
            // CPU_Usage_Label
            // 
            this.CPU_Usage_Label.AutoSize = true;
            this.CPU_Usage_Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CPU_Usage_Label.Location = new System.Drawing.Point(375, 43);
            this.CPU_Usage_Label.Name = "CPU_Usage_Label";
            this.CPU_Usage_Label.Size = new System.Drawing.Size(67, 13);
            this.CPU_Usage_Label.TabIndex = 10;
            this.CPU_Usage_Label.Text = "CPU usage :";
            // 
            // Time_Value_Label
            // 
            this.Time_Value_Label.AutoSize = true;
            this.Time_Value_Label.Location = new System.Drawing.Point(250, 65);
            this.Time_Value_Label.Name = "Time_Value_Label";
            this.Time_Value_Label.Size = new System.Drawing.Size(49, 13);
            this.Time_Value_Label.TabIndex = 9;
            this.Time_Value_Label.Text = "00:00:00";
            // 
            // Time_Label
            // 
            this.Time_Label.AutoSize = true;
            this.Time_Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Time_Label.Location = new System.Drawing.Point(200, 65);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(36, 13);
            this.Time_Label.TabIndex = 8;
            this.Time_Label.Text = "Time :";
            // 
            // Found_Errors_Value_Label
            // 
            this.Found_Errors_Value_Label.AutoSize = true;
            this.Found_Errors_Value_Label.Location = new System.Drawing.Point(285, 21);
            this.Found_Errors_Value_Label.Name = "Found_Errors_Value_Label";
            this.Found_Errors_Value_Label.Size = new System.Drawing.Size(13, 13);
            this.Found_Errors_Value_Label.TabIndex = 5;
            this.Found_Errors_Value_Label.Text = "0";
            // 
            // Crawled_Links_Value_Label
            // 
            this.Crawled_Links_Value_Label.AutoSize = true;
            this.Crawled_Links_Value_Label.Location = new System.Drawing.Point(110, 43);
            this.Crawled_Links_Value_Label.Name = "Crawled_Links_Value_Label";
            this.Crawled_Links_Value_Label.Size = new System.Drawing.Size(13, 13);
            this.Crawled_Links_Value_Label.TabIndex = 4;
            this.Crawled_Links_Value_Label.Text = "0";
            // 
            // Found_Links_Value_Label
            // 
            this.Found_Links_Value_Label.AutoSize = true;
            this.Found_Links_Value_Label.Location = new System.Drawing.Point(110, 21);
            this.Found_Links_Value_Label.Name = "Found_Links_Value_Label";
            this.Found_Links_Value_Label.Size = new System.Drawing.Size(13, 13);
            this.Found_Links_Value_Label.TabIndex = 3;
            this.Found_Links_Value_Label.Text = "0";
            // 
            // Found_Errors_Label
            // 
            this.Found_Errors_Label.AutoSize = true;
            this.Found_Errors_Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Found_Errors_Label.Location = new System.Drawing.Point(200, 21);
            this.Found_Errors_Label.Name = "Found_Errors_Label";
            this.Found_Errors_Label.Size = new System.Drawing.Size(72, 13);
            this.Found_Errors_Label.TabIndex = 2;
            this.Found_Errors_Label.Text = "Found errors :";
            // 
            // Crawled_Links_Label
            // 
            this.Crawled_Links_Label.AutoSize = true;
            this.Crawled_Links_Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Crawled_Links_Label.Location = new System.Drawing.Point(5, 43);
            this.Crawled_Links_Label.Name = "Crawled_Links_Label";
            this.Crawled_Links_Label.Size = new System.Drawing.Size(75, 13);
            this.Crawled_Links_Label.TabIndex = 1;
            this.Crawled_Links_Label.Text = "Crawled links :";
            // 
            // Found_Links_Label
            // 
            this.Found_Links_Label.AutoSize = true;
            this.Found_Links_Label.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Found_Links_Label.Location = new System.Drawing.Point(5, 21);
            this.Found_Links_Label.Name = "Found_Links_Label";
            this.Found_Links_Label.Size = new System.Drawing.Size(67, 13);
            this.Found_Links_Label.TabIndex = 0;
            this.Found_Links_Label.Text = "Found links :";
            // 
            // Crawling_Link_Label
            // 
            this.Crawling_Link_Label.AutoSize = true;
            this.Crawling_Link_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Crawling_Link_Label.ForeColor = System.Drawing.Color.Navy;
            this.Crawling_Link_Label.Location = new System.Drawing.Point(15, 170);
            this.Crawling_Link_Label.Name = "Crawling_Link_Label";
            this.Crawling_Link_Label.Size = new System.Drawing.Size(134, 24);
            this.Crawling_Link_Label.TabIndex = 12;
            this.Crawling_Link_Label.Text = "Crawling URL :";
            // 
            // Local_URL_Label
            // 
            this.Local_URL_Label.AutoSize = true;
            this.Local_URL_Label.BackColor = System.Drawing.SystemColors.Control;
            this.Local_URL_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Local_URL_Label.ForeColor = System.Drawing.Color.Navy;
            this.Local_URL_Label.Location = new System.Drawing.Point(15, 80);
            this.Local_URL_Label.Name = "Local_URL_Label";
            this.Local_URL_Label.Size = new System.Drawing.Size(106, 24);
            this.Local_URL_Label.TabIndex = 4;
            this.Local_URL_Label.Text = "Local URL :";
            // 
            // Crawling_URL_Link_Label
            // 
            this.Crawling_URL_Link_Label.AutoSize = true;
            this.Crawling_URL_Link_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crawling_URL_Link_Label.Location = new System.Drawing.Point(155, 170);
            this.Crawling_URL_Link_Label.Name = "Crawling_URL_Link_Label";
            this.Crawling_URL_Link_Label.Size = new System.Drawing.Size(57, 24);
            this.Crawling_URL_Link_Label.TabIndex = 15;
            this.Crawling_URL_Link_Label.TabStop = true;
            this.Crawling_URL_Link_Label.Text = "None";
            // 
            // Found_Errors_List_Box
            // 
            this.Found_Errors_List_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Found_Errors_List_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Found_Errors_List_Box.FormattingEnabled = true;
            this.Found_Errors_List_Box.HorizontalScrollbar = true;
            this.Found_Errors_List_Box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Found_Errors_List_Box.Location = new System.Drawing.Point(3, 3);
            this.Found_Errors_List_Box.Name = "Found_Errors_List_Box";
            this.Found_Errors_List_Box.Size = new System.Drawing.Size(1251, 459);
            this.Found_Errors_List_Box.TabIndex = 0;
            // 
            // Found_Links_List_Box
            // 
            this.Found_Links_List_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Found_Links_List_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Found_Links_List_Box.FormattingEnabled = true;
            this.Found_Links_List_Box.HorizontalScrollbar = true;
            this.Found_Links_List_Box.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Found_Links_List_Box.Location = new System.Drawing.Point(3, 3);
            this.Found_Links_List_Box.Name = "Found_Links_List_Box";
            this.Found_Links_List_Box.Size = new System.Drawing.Size(1251, 459);
            this.Found_Links_List_Box.TabIndex = 0;
            // 
            // User_Links_List_Box
            // 
            this.User_Links_List_Box.Cursor = System.Windows.Forms.Cursors.Hand;
            this.User_Links_List_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_Links_List_Box.FormattingEnabled = true;
            this.User_Links_List_Box.HorizontalScrollbar = true;
            this.User_Links_List_Box.Location = new System.Drawing.Point(3, 3);
            this.User_Links_List_Box.Name = "User_Links_List_Box";
            this.User_Links_List_Box.Size = new System.Drawing.Size(1251, 459);
            this.User_Links_List_Box.TabIndex = 0;
            // 
            // Application_Picture_Box
            // 
            this.Application_Picture_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.Application_Picture_Box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Application_Picture_Box.BackgroundImage")));
            this.Application_Picture_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Application_Picture_Box.Location = new System.Drawing.Point(0, 0);
            this.Application_Picture_Box.Name = "Application_Picture_Box";
            this.Application_Picture_Box.Size = new System.Drawing.Size(13000, 78);
            this.Application_Picture_Box.TabIndex = 0;
            this.Application_Picture_Box.TabStop = false;
            // 
            // Loading_Picture_Box
            // 
            this.Loading_Picture_Box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Loading_Picture_Box.BackgroundImage")));
            this.Loading_Picture_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Loading_Picture_Box.Location = new System.Drawing.Point(680, 109);
            this.Loading_Picture_Box.Name = "Loading_Picture_Box";
            this.Loading_Picture_Box.Size = new System.Drawing.Size(50, 50);
            this.Loading_Picture_Box.TabIndex = 9;
            this.Loading_Picture_Box.TabStop = false;
            // 
            // Results_Tab_Control
            // 
            this.Results_Tab_Control.Controls.Add(this.tabPage1);
            this.Results_Tab_Control.Controls.Add(this.tabPage2);
            this.Results_Tab_Control.Controls.Add(this.tabPage3);
            this.Results_Tab_Control.Location = new System.Drawing.Point(15, 200);
            this.Results_Tab_Control.Name = "Results_Tab_Control";
            this.Results_Tab_Control.SelectedIndex = 0;
            this.Results_Tab_Control.Size = new System.Drawing.Size(1265, 491);
            this.Results_Tab_Control.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Found_Links_List_Box);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1257, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Found Links";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Found_Errors_List_Box);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1257, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Found Errors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.User_Links_List_Box);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1257, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "User Links";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // User_Link_Text_Box
            // 
            this.User_Link_Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.User_Link_Text_Box.ForeColor = System.Drawing.Color.Blue;
            this.User_Link_Text_Box.Location = new System.Drawing.Point(15, 105);
            this.User_Link_Text_Box.Name = "User_Link_Text_Box";
            this.User_Link_Text_Box.Size = new System.Drawing.Size(500, 24);
            this.User_Link_Text_Box.TabIndex = 3;
            this.User_Link_Text_Box.Text = "Ex:http://www.example.com";
            this.User_Link_Text_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.User_Link_Text_Box_KeyPress);
            // 
            // User_path_Text_Box
            // 
            this.User_path_Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.User_path_Text_Box.ForeColor = System.Drawing.Color.Blue;
            this.User_path_Text_Box.Location = new System.Drawing.Point(15, 140);
            this.User_path_Text_Box.Multiline = true;
            this.User_path_Text_Box.Name = "User_path_Text_Box";
            this.User_path_Text_Box.Size = new System.Drawing.Size(500, 24);
            this.User_path_Text_Box.TabIndex = 10;
            // 
            // Timer_Timer
            // 
            this.Timer_Timer.Enabled = true;
            this.Timer_Timer.Interval = 1000;
            this.Timer_Timer.Tick += new System.EventHandler(this.Timer_Timer_Tick);
            // 
            // Web_Crawler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1274, 690);
            this.Controls.Add(this.Crawling_URL_Link_Label);
            this.Controls.Add(this.Statistics_GroupBox);
            this.Controls.Add(this.Crawling_Link_Label);
            this.Controls.Add(this.Browse_Button);
            this.Controls.Add(this.User_path_Text_Box);
            this.Controls.Add(this.Loading_Picture_Box);
            this.Controls.Add(this.Results_Tab_Control);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Pause_And_Continue_Button);
            this.Controls.Add(this.User_Link_Text_Box);
            this.Controls.Add(this.Local_URL_Label);
            this.Controls.Add(this.Crawl_Button);
            this.Controls.Add(this.Application_Picture_Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Web_Crawler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Crawler";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closing_Application);
            this.Statistics_GroupBox.ResumeLayout(false);
            this.Statistics_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Application_Picture_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Loading_Picture_Box)).EndInit();
            this.Results_Tab_Control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        #region Buttons
        private System.Windows.Forms.Button Browse_Button;
        private System.Windows.Forms.Button Crawl_Button;
        private System.Windows.Forms.Button Pause_And_Continue_Button;
        private System.Windows.Forms.Button Stop_Button;
        #endregion

        #region Folder browser dialoges
        private System.Windows.Forms.FolderBrowserDialog Browse_Link_FolderBrowserDialog;
        #endregion

        #region Group boxes
        private System.Windows.Forms.GroupBox Statistics_GroupBox;
        #endregion

        #region Labels
        private System.Windows.Forms.Label Available_RAM_Label;
        private System.Windows.Forms.Label Availabel_RAM_Value_Label;
        private System.Windows.Forms.Label CPU_Usage_Label;
        private System.Windows.Forms.Label CPU_Usage_Value_Label;
        private System.Windows.Forms.Label Crawled_Links_Label;
        private System.Windows.Forms.Label Crawled_Links_Value_Label;
        private System.Windows.Forms.Label Crawling_Link_Label;
        private System.Windows.Forms.Label Downloaded_Links_Label;
        private System.Windows.Forms.Label Downloaded_Links_Value_Label;
        private System.Windows.Forms.Label Found_Errors_Label;
        private System.Windows.Forms.Label Found_Errors_Value_Label;
        private System.Windows.Forms.Label Found_Links_Label;
        private System.Windows.Forms.Label Found_Links_Value_Label;
        private System.Windows.Forms.Label Internet_Access_Value_Label;
        private System.Windows.Forms.Label Internet_Access_Label;
        private System.Windows.Forms.Label Local_URL_Label;
        private System.Windows.Forms.Label Time_Label;
        private System.Windows.Forms.Label Time_Value_Label;
        #endregion

        #region Link labels
        private System.Windows.Forms.LinkLabel Crawling_URL_Link_Label;
        #endregion

        #region List boxes
        private System.Windows.Forms.ListBox Found_Errors_List_Box;
        private System.Windows.Forms.ListBox Found_Links_List_Box;
        private System.Windows.Forms.ListBox User_Links_List_Box;
        #endregion

        #region Picture boxes
        private System.Windows.Forms.PictureBox Application_Picture_Box;
        private System.Windows.Forms.PictureBox Loading_Picture_Box;
        #endregion

        #region Tab controls
        private System.Windows.Forms.TabControl Results_Tab_Control;
        #endregion

        #region Tab pages
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        #endregion

        #region Text boxes

        public System.Windows.Forms.TextBox User_Link_Text_Box;
        public System.Windows.Forms.TextBox User_path_Text_Box;
        #endregion

        #region Timers
        private System.Windows.Forms.Timer Timer_Timer;
        #endregion
    }
}