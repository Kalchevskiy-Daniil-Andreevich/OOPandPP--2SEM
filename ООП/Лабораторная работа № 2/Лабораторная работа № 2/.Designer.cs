namespace Лабораторная_работа___2
{
    partial class FileBook
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileBook));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FormatBook_combobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SizeOfFileBook = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NameOfBook = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CodeUDK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ListOfAuthor = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CountOfPages = new System.Windows.Forms.ComboBox();
            this.Year = new System.Windows.Forms.ComboBox();
            this.Publishing = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.OutputWindow = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.AuthorData = new System.Windows.Forms.Button();
            this.WriteDataInFile = new System.Windows.Forms.Button();
            this.DataOfPubl = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.InfoOfPrograms = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Open = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Close = new System.Windows.Forms.ToolStripButton();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.SortButton = new System.Windows.Forms.ToolStripButton();
            this.ClearButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Формат = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchInfo = new System.Windows.Forms.Button();
            this.XMLOfFormat = new System.Windows.Forms.Button();
            this.ClearOfTable = new System.Windows.Forms.Button();
            this.SortInfo = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Формат книги";
            // 
            // FormatBook_combobox
            // 
            this.FormatBook_combobox.BackColor = System.Drawing.SystemColors.Info;
            this.FormatBook_combobox.FormattingEnabled = true;
            this.FormatBook_combobox.Items.AddRange(new object[] {
            "FB2",
            "RTF",
            "EPUB",
            "PDF",
            "TXT",
            "MOBI",
            "LRF",
            "EXT"});
            this.FormatBook_combobox.Location = new System.Drawing.Point(11, 57);
            this.FormatBook_combobox.Name = "FormatBook_combobox";
            this.FormatBook_combobox.Size = new System.Drawing.Size(186, 24);
            this.FormatBook_combobox.TabIndex = 4;
            this.FormatBook_combobox.SelectedIndexChanged += new System.EventHandler(this.FormatBook_combobox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Размер файла книги";
            // 
            // SizeOfFileBook
            // 
            this.SizeOfFileBook.BackColor = System.Drawing.SystemColors.Info;
            this.SizeOfFileBook.FormattingEnabled = true;
            this.SizeOfFileBook.Items.AddRange(new object[] {
            "Большой - 60×84/8",
            "Станлартный - 60×84/16",
            "Маленький - 60×84/32",
            "Большой - 60×90/8",
            "Станлартный - 60×90/16",
            "Маленький - 60×90/32",
            "Увеличеный - 70×90/16",
            "Маленький - 70×90/32",
            "Очень большой -70×100/8"});
            this.SizeOfFileBook.Location = new System.Drawing.Point(11, 103);
            this.SizeOfFileBook.Name = "SizeOfFileBook";
            this.SizeOfFileBook.Size = new System.Drawing.Size(186, 24);
            this.SizeOfFileBook.TabIndex = 6;
            this.SizeOfFileBook.SelectedIndexChanged += new System.EventHandler(this.SizeOfFileBook_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Название книги";
            // 
            // NameOfBook
            // 
            this.NameOfBook.BackColor = System.Drawing.SystemColors.Info;
            this.NameOfBook.Location = new System.Drawing.Point(11, 149);
            this.NameOfBook.Name = "NameOfBook";
            this.NameOfBook.Size = new System.Drawing.Size(140, 22);
            this.NameOfBook.TabIndex = 8;
            this.NameOfBook.TextChanged += new System.EventHandler(this.NameOfBook_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Код УДК";
            // 
            // CodeUDK
            // 
            this.CodeUDK.BackColor = System.Drawing.SystemColors.Info;
            this.CodeUDK.Location = new System.Drawing.Point(11, 193);
            this.CodeUDK.Name = "CodeUDK";
            this.CodeUDK.Size = new System.Drawing.Size(140, 22);
            this.CodeUDK.TabIndex = 10;
            this.CodeUDK.TextChanged += new System.EventHandler(this.CodeUDK_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Количество страниц";
            // 
            // ListOfAuthor
            // 
            this.ListOfAuthor.BackColor = System.Drawing.SystemColors.Info;
            this.ListOfAuthor.FormattingEnabled = true;
            this.ListOfAuthor.ItemHeight = 16;
            this.ListOfAuthor.Items.AddRange(new object[] {
            "Ральф Эллисон",
            "Уильям Фолкнер",
            "Джейн Остин",
            "Джордж Элиот",
            "Джозеф Хеллер",
            "Салман Рушди",
            "Ричард Райт",
            "Карл Маркс",
            "Томас Гоббс",
            "Джон Керуак",
            "Гюстав Флобер"});
            this.ListOfAuthor.Location = new System.Drawing.Point(11, 375);
            this.ListOfAuthor.Name = "ListOfAuthor";
            this.ListOfAuthor.Size = new System.Drawing.Size(200, 196);
            this.ListOfAuthor.TabIndex = 13;
            this.ListOfAuthor.SelectedIndexChanged += new System.EventHandler(this.ListOfAuthor_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Издательство";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Год";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Список авторов";
            // 
            // CountOfPages
            // 
            this.CountOfPages.BackColor = System.Drawing.SystemColors.Info;
            this.CountOfPages.FormattingEnabled = true;
            this.CountOfPages.Items.AddRange(new object[] {
            "1-170 страниц",
            "1-220 страниц",
            "1-300 страниц",
            "1-325 страниц",
            "1-500 страниц"});
            this.CountOfPages.Location = new System.Drawing.Point(11, 237);
            this.CountOfPages.Name = "CountOfPages";
            this.CountOfPages.Size = new System.Drawing.Size(186, 24);
            this.CountOfPages.TabIndex = 21;
            this.CountOfPages.SelectedIndexChanged += new System.EventHandler(this.CountOfPages_SelectedIndexChanged);
            // 
            // Year
            // 
            this.Year.BackColor = System.Drawing.SystemColors.Info;
            this.Year.FormattingEnabled = true;
            this.Year.Items.AddRange(new object[] {
            "1990-2000 годов",
            "2000-2005 годов",
            "2005-2012 годов",
            "2012-2018 годов",
            "2018-2023годов"});
            this.Year.Location = new System.Drawing.Point(11, 329);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(186, 24);
            this.Year.TabIndex = 23;
            this.Year.SelectedIndexChanged += new System.EventHandler(this.Year_SelectedIndexChanged);
            // 
            // Publishing
            // 
            this.Publishing.BackColor = System.Drawing.SystemColors.Info;
            this.Publishing.FormattingEnabled = true;
            this.Publishing.Items.AddRange(new object[] {
            "«Эксмо»",
            "«Вильямс»",
            "«Юрайт»",
            "«Добрая книга»",
            " «Манн, Иванов и Фербер»",
            " «РИПОЛ Классик»",
            "«Росмэн»",
            "«Астрель-СПб»",
            "«Азбука»"});
            this.Publishing.Location = new System.Drawing.Point(11, 283);
            this.Publishing.Name = "Publishing";
            this.Publishing.Size = new System.Drawing.Size(186, 24);
            this.Publishing.TabIndex = 24;
            this.Publishing.SelectedIndexChanged += new System.EventHandler(this.Publishing_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 574);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Дата загрузки";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddButton.Location = new System.Drawing.Point(11, 728);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(232, 38);
            this.AddButton.TabIndex = 28;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // OutputWindow
            // 
            this.OutputWindow.Location = new System.Drawing.Point(339, 38);
            this.OutputWindow.Name = "OutputWindow";
            this.OutputWindow.Size = new System.Drawing.Size(461, 334);
            this.OutputWindow.TabIndex = 29;
            this.OutputWindow.Text = "";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.Info;
            this.dateTimePicker.Location = new System.Drawing.Point(11, 593);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(274, 22);
            this.dateTimePicker.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 618);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Автор";
            // 
            // AuthorData
            // 
            this.AuthorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.AuthorData.Location = new System.Drawing.Point(11, 637);
            this.AuthorData.Name = "AuthorData";
            this.AuthorData.Size = new System.Drawing.Size(321, 34);
            this.AuthorData.TabIndex = 32;
            this.AuthorData.Text = "Дополнительные данные о авторе";
            this.AuthorData.UseVisualStyleBackColor = false;
            this.AuthorData.Click += new System.EventHandler(this.AuthorData_Click);
            // 
            // WriteDataInFile
            // 
            this.WriteDataInFile.BackColor = System.Drawing.SystemColors.HotTrack;
            this.WriteDataInFile.Location = new System.Drawing.Point(11, 772);
            this.WriteDataInFile.Name = "WriteDataInFile";
            this.WriteDataInFile.Size = new System.Drawing.Size(232, 38);
            this.WriteDataInFile.TabIndex = 33;
            this.WriteDataInFile.Text = "Запись данных в json-файл";
            this.WriteDataInFile.UseVisualStyleBackColor = false;
            this.WriteDataInFile.Click += new System.EventHandler(this.WriteDataInFile_Click);
            // 
            // DataOfPubl
            // 
            this.DataOfPubl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DataOfPubl.Location = new System.Drawing.Point(11, 693);
            this.DataOfPubl.Name = "DataOfPubl";
            this.DataOfPubl.Size = new System.Drawing.Size(318, 29);
            this.DataOfPubl.TabIndex = 34;
            this.DataOfPubl.Text = "Дополнительные данные о издательстве";
            this.DataOfPubl.UseVisualStyleBackColor = false;
            this.DataOfPubl.Click += new System.EventHandler(this.DataOfPubl_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 674);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "Издательство";
            // 
            // InfoOfPrograms
            // 
            this.InfoOfPrograms.Location = new System.Drawing.Point(11, 825);
            this.InfoOfPrograms.Name = "InfoOfPrograms";
            this.InfoOfPrograms.Size = new System.Drawing.Size(272, 38);
            this.InfoOfPrograms.TabIndex = 36;
            this.InfoOfPrograms.Text = "О программе";
            this.InfoOfPrograms.UseVisualStyleBackColor = true;
            this.InfoOfPrograms.Click += new System.EventHandler(this.InfoOfPrograms_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 893);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1669, 22);
            this.statusStrip1.TabIndex = 38;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Open
            // 
            this.Open.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Open.BackgroundImage")));
            this.Open.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.Open.FlatAppearance.BorderSize = 0;
            this.Open.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Open.Location = new System.Drawing.Point(771, 0);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(29, 27);
            this.Open.TabIndex = 39;
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Visible = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Close,
            this.SearchButton,
            this.SortButton,
            this.ClearButton,
            this.toolStripButton4,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1669, 27);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Close
            // 
            this.Close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(29, 24);
            this.Close.Text = "toolStripButton1";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(29, 24);
            this.SearchButton.Text = "SearchButton";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SortButton.Image = ((System.Drawing.Image)(resources.GetObject("SortButton.Image")));
            this.SortButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(29, 24);
            this.SortButton.Text = "SortButton";
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(29, 24);
            this.ClearButton.Text = "ClearButton";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Формат,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(339, 394);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1301, 469);
            this.dataGridView1.TabIndex = 40;
            // 
            // Формат
            // 
            this.Формат.HeaderText = "Формат книги";
            this.Формат.MinimumWidth = 6;
            this.Формат.Name = "Формат";
            this.Формат.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Размер файла книги";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название книги";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Код УДК";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Количество страниц";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Издательство";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Год";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Список авторов";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Дата загрузки";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Отчество и ID";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // SearchInfo
            // 
            this.SearchInfo.Location = new System.Drawing.Point(828, 329);
            this.SearchInfo.Name = "SearchInfo";
            this.SearchInfo.Size = new System.Drawing.Size(196, 43);
            this.SearchInfo.TabIndex = 41;
            this.SearchInfo.Text = "Поиск";
            this.SearchInfo.UseVisualStyleBackColor = true;
            this.SearchInfo.Click += new System.EventHandler(this.SearchInfo_Click);
            // 
            // XMLOfFormat
            // 
            this.XMLOfFormat.Location = new System.Drawing.Point(1030, 329);
            this.XMLOfFormat.Name = "XMLOfFormat";
            this.XMLOfFormat.Size = new System.Drawing.Size(196, 43);
            this.XMLOfFormat.TabIndex = 42;
            this.XMLOfFormat.Text = "XML-формат";
            this.XMLOfFormat.UseVisualStyleBackColor = true;
            this.XMLOfFormat.Click += new System.EventHandler(this.XMLOfFormat_Click);
            // 
            // ClearOfTable
            // 
            this.ClearOfTable.Location = new System.Drawing.Point(1232, 329);
            this.ClearOfTable.Name = "ClearOfTable";
            this.ClearOfTable.Size = new System.Drawing.Size(196, 43);
            this.ClearOfTable.TabIndex = 43;
            this.ClearOfTable.Text = "Очистить";
            this.ClearOfTable.UseVisualStyleBackColor = true;
            this.ClearOfTable.Click += new System.EventHandler(this.ClearOfTable_Click);
            // 
            // SortInfo
            // 
            this.SortInfo.Location = new System.Drawing.Point(1434, 329);
            this.SortInfo.Name = "SortInfo";
            this.SortInfo.Size = new System.Drawing.Size(196, 43);
            this.SortInfo.TabIndex = 44;
            this.SortInfo.Text = "Сортировка";
            this.SortInfo.UseVisualStyleBackColor = true;
            this.SortInfo.Click += new System.EventHandler(this.SortInfo_Click);
            // 
            // FileBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1669, 915);
            this.Controls.Add(this.SortInfo);
            this.Controls.Add(this.ClearOfTable);
            this.Controls.Add(this.XMLOfFormat);
            this.Controls.Add(this.SearchInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.InfoOfPrograms);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DataOfPubl);
            this.Controls.Add(this.WriteDataInFile);
            this.Controls.Add(this.AuthorData);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.OutputWindow);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Publishing);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.CountOfPages);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ListOfAuthor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CodeUDK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NameOfBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SizeOfFileBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FormatBook_combobox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FileBook";
            this.Text = "Файл книги";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FormatBook_combobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SizeOfFileBook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameOfBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CodeUDK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox ListOfAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CountOfPages;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.ComboBox Publishing;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.RichTextBox OutputWindow;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AuthorData;
        private System.Windows.Forms.Button WriteDataInFile;
        private System.Windows.Forms.Button DataOfPubl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button InfoOfPrograms;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Формат;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button SearchInfo;
        private System.Windows.Forms.Button XMLOfFormat;
        private System.Windows.Forms.Button ClearOfTable;
        private System.Windows.Forms.Button SortInfo;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ToolStripButton SortButton;
        private System.Windows.Forms.ToolStripButton ClearButton;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}

