using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Data;
using System.ComponentModel;
using System.Text.RegularExpressions;
using Лабораторная_работа___2;
using System.ComponentModel.DataAnnotations;

namespace Лабораторная_работа___2
{
    public partial class FileBook : Form
    {
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        Timer timer;
        public FileBook()
        {
            InitializeComponent();
            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Текущие дата и время:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
        }
      
        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }
        public static FilesBooks filebook = new FilesBooks();
        private void FormatBook_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filebook.FormatBook = FormatBook_combobox.Items[FormatBook_combobox.SelectedIndex].ToString();
        }
        private void SizeOfFileBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            filebook.SizeFileBook = SizeOfFileBook.Items[SizeOfFileBook.SelectedIndex].ToString();
        }
        private void NameOfBook_TextChanged(object sender, EventArgs e)
        {
            filebook.NameBook = NameOfBook.Text;
        }
        private void CodeUDK_TextChanged(object sender, EventArgs e)
        {
            filebook.Code = CodeUDK.Text;
        }
        private void CountOfPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            filebook.CountOfPages = CountOfPages.Items[CountOfPages.SelectedIndex].ToString();
        }
        private void Publishing_SelectedIndexChanged(object sender, EventArgs e)
        {
            filebook.Publishing = Publishing.Items[Publishing.SelectedIndex].ToString();
        }
        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {
            filebook.Years = Year.Items[Year.SelectedIndex].ToString();
        }
        private void ListOfAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            filebook.ListOfAuthor = ListOfAuthor.Items[ListOfAuthor.SelectedIndex].ToString();
        }
        private void AuthorData_Click(object sender, EventArgs e)
        {
            Form form = new Author();
            form.Show();
        }
        private void DataOfPubl_Click(object sender, EventArgs e)
        {
            Form form = new Publishing();
            form.Show();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                OutputWindow.Text = "Электронная библиотека" + "\n\n";
                OutputWindow.Text += "Формат книги: " + filebook.FormatBook + "\n";
                OutputWindow.Text += "Размер файла книги: " + filebook.SizeFileBook + "\n";
                OutputWindow.Text += "Название книги: " + filebook.NameBook + "\n";
                OutputWindow.Text += "Код УДК: " + filebook.Code + "\n";
                OutputWindow.Text += "Количество страниц: " + filebook.CountOfPages + "\n";
                OutputWindow.Text += "Издательство: " + filebook.Publishing + "\n";
                OutputWindow.Text += "Год: " + filebook.Years + "\n";
                OutputWindow.Text += "Список авторов: " + filebook.ListOfAuthor + "\n";
                OutputWindow.Text += "Дата загрузки: " + dateTimePicker.Value + "\n\n";
                OutputWindow.Text += "Отчество автора: " + filebook.author.OtchestvoAuthor + "\n";
                OutputWindow.Text += "Страна автора: " + filebook.author.Country + "\n";
                OutputWindow.Text += "Id автора: " + filebook.author.Id + "\n\n";
                OutputWindow.Text += "Страна издательства: " + filebook.pub.Countr + "\n";
                OutputWindow.Text += "Город: " + filebook.pub.City + "\n";
                OutputWindow.Text += "Год основания: " + filebook.pub.YearOfGrounds + "\n";
                OutputWindow.Text += "Паспорт: " + filebook.author.NubmerPassport + "\n";


                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = filebook.FormatBook;
                dataGridView1.Rows[n].Cells[1].Value = filebook.SizeFileBook;
                dataGridView1.Rows[n].Cells[2].Value = filebook.NameBook;
                dataGridView1.Rows[n].Cells[3].Value = filebook.Code;
                dataGridView1.Rows[n].Cells[4].Value = filebook.CountOfPages;
                dataGridView1.Rows[n].Cells[5].Value = filebook.Publishing;
                dataGridView1.Rows[n].Cells[6].Value = filebook.Years;
                dataGridView1.Rows[n].Cells[7].Value = filebook.ListOfAuthor;
                dataGridView1.Rows[n].Cells[8].Value = dateTimePicker.Value;
                dataGridView1.Rows[n].Cells[9].Value = filebook.author.OtchestvoAuthor + filebook.author.Id;

                FileBook book = new FileBook();
                var results = new List<ValidationResult>();
                var context = new ValidationContext(book);
                if (!Validator.TryValidateObject(book, context, results, true))
                {
                    foreach (var error in results)
                    {
                        string strWithErrore = error.ErrorMessage;
                    }
                }
            }
            catch (NullReferenceException)
            {
                OutputWindow.Text = "Некорректные данные";
            }
        }
        private void WriteDataInFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter file = new StreamWriter("data.json", true))
                {
                    file.Write("Формат книги: " + Convert.ToString(filebook.FormatBook) +
                        "\nРазмер файла книги: " + Convert.ToString(filebook.SizeFileBook) +
                        "\nНазвание книги: " + Convert.ToString(filebook.NameBook) +
                        "\nКод УДК: " + Convert.ToString(filebook.Code) +
                        "\nКоличество страниц: " + Convert.ToString(filebook.CountOfPages) +
                        "\nИздательство: " + Convert.ToString(filebook.Publishing) +
                        "\nГод: " + Convert.ToString(filebook.Years) +
                        "\nСписок авторов: " + Convert.ToString(filebook.ListOfAuthor) +
                        "\nДата загрузки: " + Convert.ToString(dateTimePicker.Value) +
                        "\nОтчество автора: " + Convert.ToString(filebook.author.OtchestvoAuthor) +
                        "\nСтрана автора: " + Convert.ToString(filebook.author.Country) + 
                        "\nId автора: " + Convert.ToString(filebook.author.Id) +
                        "\nСтрана издательства: " + Convert.ToString(filebook.pub.Countr) +
                        "\nГород издательства: " + Convert.ToString(filebook.pub.City) +
                        "\nГод основания: " + Convert.ToString(filebook.pub.YearOfGrounds));
                }
                         MessageBox.Show("Данные записались в файл!");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка!");
            }
        }
        private void InfoOfPrograms_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия 17.4\n" + "Кальчевский Даниил Андреевич");
        }
        private void Close_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            Open.Visible = true;
        }
        private void Open_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            Open.Visible = false;
        }
        private void SearchInfo_Click(object sender, EventArgs e)
        {
            Form f = new Search();
            f.Show();
        }
        private void XMLOfFormat_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                dt.TableName = "Book";
                dt.Columns.Add("FormatBook");
                dt.Columns.Add("SizeFileBook");
                dt.Columns.Add("NameBook");

                dt.Columns.Add("Code");
                dt.Columns.Add("CountOfPages");
                dt.Columns.Add("Publishing");
                dt.Columns.Add("Years");
                dt.Columns.Add("ListOfAuthor");
                dt.Columns.Add("NubmerPassport");
                ds.Tables.Add(dt);

                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    DataRow row = ds.Tables["Book"].NewRow();
                    row["FormatBook"] = r.Cells[0].Value;
                    row["SizeFileBook"] = r.Cells[1].Value;
                    row["NameBook"] = r.Cells[2].Value;

                    row["Code"] = r.Cells[3].Value;
                    row["CountOfPages"] = r.Cells[4].Value;
                    row["Publishing"] = r.Cells[5].Value;
                    row["Years"] = r.Cells[6].Value;
                    row["ListOfAuthor"] = r.Cells[7].Value;
                    row["NubmerPassport"] = r.Cells[8].Value;
                    ds.Tables["BOOK"].Rows.Add(row);
                }
                ds.WriteXml("Data.xml");

                MessageBox.Show("XML файл успешно сохранен.", "Выполнено.");
            }
            catch
            {
                MessageBox.Show("Невозможно сохранить XML файл.", "Ошибка.");
            }
        }
        private void ClearOfTable_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Таблица пустая.", "Ошибка.");
            }
        }
        private void SortInfo_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Column8"], ListSortDirection.Ascending);
            this.dataGridView1.Sort(this.dataGridView1.Columns["Column2"], ListSortDirection.Ascending);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Sort(this.dataGridView1.Columns["Column8"], ListSortDirection.Ascending);
            this.dataGridView1.Sort(this.dataGridView1.Columns["Column2"], ListSortDirection.Ascending);
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            FormatBook_combobox.Text = "";
            SizeOfFileBook.Text = "";
            NameOfBook.Text = "";
            CodeUDK.Text = "";
            CountOfPages.Text = "";
            Publishing.Text = "";
            Year.Text = "";
            ListOfAuthor.Text = "";
            dateTimePicker.Text = "";

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Таблица пустая.", "Ошибка.");
            }
        }
    }
}


