namespace Лабораторная_работа___2
{
    partial class Publishing
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CountrOfPubl = new System.Windows.Forms.ComboBox();
            this.CityOfPubl = new System.Windows.Forms.TextBox();
            this.YearGrounds = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Страна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Город";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Год основания";
            // 
            // CountrOfPubl
            // 
            this.CountrOfPubl.FormattingEnabled = true;
            this.CountrOfPubl.Items.AddRange(new object[] {
            "Россия",
            "Америка",
            "Япония",
            "Китай",
            "Англия"});
            this.CountrOfPubl.Location = new System.Drawing.Point(15, 37);
            this.CountrOfPubl.Name = "CountrOfPubl";
            this.CountrOfPubl.Size = new System.Drawing.Size(121, 24);
            this.CountrOfPubl.TabIndex = 3;
            this.CountrOfPubl.SelectedIndexChanged += new System.EventHandler(this.CountrOfPubl_SelectedIndexChanged);
            // 
            // CityOfPubl
            // 
            this.CityOfPubl.Location = new System.Drawing.Point(15, 102);
            this.CityOfPubl.Name = "CityOfPubl";
            this.CityOfPubl.Size = new System.Drawing.Size(121, 22);
            this.CityOfPubl.TabIndex = 4;
            this.CityOfPubl.TextChanged += new System.EventHandler(this.CityOfPubl_TextChanged);
            // 
            // YearGrounds
            // 
            this.YearGrounds.Location = new System.Drawing.Point(15, 169);
            this.YearGrounds.Name = "YearGrounds";
            this.YearGrounds.Size = new System.Drawing.Size(116, 22);
            this.YearGrounds.TabIndex = 5;
            this.YearGrounds.TextChanged += new System.EventHandler(this.YearGrounds_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(15, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Готово";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Publishing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.YearGrounds);
            this.Controls.Add(this.CityOfPubl);
            this.Controls.Add(this.CountrOfPubl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Publishing";
            this.Text = "Publishing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CountrOfPubl;
        private System.Windows.Forms.TextBox CityOfPubl;
        private System.Windows.Forms.TextBox YearGrounds;
        private System.Windows.Forms.Button button1;
    }
}