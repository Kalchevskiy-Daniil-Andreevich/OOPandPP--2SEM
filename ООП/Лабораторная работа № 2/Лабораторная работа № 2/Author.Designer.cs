namespace Лабораторная_работа___2
{
    partial class Author
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
            this.label3 = new System.Windows.Forms.Label();
            this.OtchestvoAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CountryAuthor = new System.Windows.Forms.ComboBox();
            this.ReadyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberPassport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество";
            // 
            // OtchestvoAuthor
            // 
            this.OtchestvoAuthor.BackColor = System.Drawing.SystemColors.Info;
            this.OtchestvoAuthor.Location = new System.Drawing.Point(12, 28);
            this.OtchestvoAuthor.Name = "OtchestvoAuthor";
            this.OtchestvoAuthor.Size = new System.Drawing.Size(138, 22);
            this.OtchestvoAuthor.TabIndex = 5;
            this.OtchestvoAuthor.TextChanged += new System.EventHandler(this.OtchestvoAuthor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Страна";
            // 
            // CountryAuthor
            // 
            this.CountryAuthor.AutoCompleteCustomSource.AddRange(new string[] {
            "Россия",
            "Америка"});
            this.CountryAuthor.BackColor = System.Drawing.SystemColors.Info;
            this.CountryAuthor.FormattingEnabled = true;
            this.CountryAuthor.Items.AddRange(new object[] {
            "Россия",
            "Америка",
            "Германия",
            "Япония"});
            this.CountryAuthor.Location = new System.Drawing.Point(12, 93);
            this.CountryAuthor.Name = "CountryAuthor";
            this.CountryAuthor.Size = new System.Drawing.Size(138, 24);
            this.CountryAuthor.TabIndex = 7;
            this.CountryAuthor.SelectedIndexChanged += new System.EventHandler(this.CountryAuthor_SelectedIndexChanged);
            // 
            // ReadyButton
            // 
            this.ReadyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ReadyButton.Location = new System.Drawing.Point(12, 244);
            this.ReadyButton.Name = "ReadyButton";
            this.ReadyButton.Size = new System.Drawing.Size(213, 33);
            this.ReadyButton.TabIndex = 10;
            this.ReadyButton.Text = "Готово";
            this.ReadyButton.UseVisualStyleBackColor = false;
            this.ReadyButton.Click += new System.EventHandler(this.ReadyButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // InfoID
            // 
            this.InfoID.BackColor = System.Drawing.SystemColors.Info;
            this.InfoID.Location = new System.Drawing.Point(12, 150);
            this.InfoID.Name = "InfoID";
            this.InfoID.Size = new System.Drawing.Size(138, 22);
            this.InfoID.TabIndex = 12;
            this.InfoID.TextChanged += new System.EventHandler(this.InfoID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Номер паспорта";
            // 
            // NumberPassport
            // 
            this.NumberPassport.BackColor = System.Drawing.SystemColors.Info;
            this.NumberPassport.Location = new System.Drawing.Point(12, 208);
            this.NumberPassport.Name = "NumberPassport";
            this.NumberPassport.Size = new System.Drawing.Size(138, 22);
            this.NumberPassport.TabIndex = 14;
            this.NumberPassport.TextChanged += new System.EventHandler(this.NumberPassport_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Введите верно номер паспорта";
            // 
            // Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumberPassport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InfoID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReadyButton);
            this.Controls.Add(this.CountryAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OtchestvoAuthor);
            this.Controls.Add(this.label3);
            this.Name = "Author";
            this.Text = "Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OtchestvoAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CountryAuthor;
        private System.Windows.Forms.Button ReadyButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InfoID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberPassport;
        private System.Windows.Forms.Label label5;
    }
}