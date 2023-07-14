using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа___2
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();

            if (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Таблица пустая.", "Ошибка.");
            }

            if (File.Exists("Data.xml"))
            {
                DataSet ds = new DataSet();
                ds.ReadXml("Data.xml");

                foreach (DataRow item in ds.Tables["BOOK"].Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item["FormatBook"];
                    dataGridView2.Rows[n].Cells[1].Value = item["SizeFileBook"];
                    dataGridView2.Rows[n].Cells[2].Value = item["NameBook"];

                    dataGridView2.Rows[n].Cells[3].Value = item["Code"];
                    dataGridView2.Rows[n].Cells[4].Value = item["CountOfPages"];
                    dataGridView2.Rows[n].Cells[5].Value = item["Publishing"];
                    dataGridView2.Rows[n].Cells[6].Value = item["Years"];
                    dataGridView2.Rows[n].Cells[7].Value = item["ListOfAuthor"];
                }
            }
            else
            {
                MessageBox.Show("XML файл не найден.", "Ошибка.");
            }

            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
            {
                if (dataGridView2.Rows[i].Cells[0].Value.ToString() == "")
                {
                    dataGridView2.Rows.RemoveAt(i);
                    i--;
                }
            }
        }
        public static Search search = new Search();
        private void SearchOfInfo_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                    if (dataGridView2.Rows[i].Cells[j].Value != null)
                        if (dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView2.Rows[i].Selected = true;
                            break;
                        }
            }
        }
        private void CloseWin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
