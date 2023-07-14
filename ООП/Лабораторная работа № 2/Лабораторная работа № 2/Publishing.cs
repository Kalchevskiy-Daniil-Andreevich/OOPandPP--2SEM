using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа___2
{
    public partial class Publishing : Form
    {
        public Publishing()
        {
            InitializeComponent();
        }
        public static Publ publ = new Publ();

        private void CountrOfPubl_SelectedIndexChanged(object sender, EventArgs e)
        {
            publ.Countr = CountrOfPubl.Items[CountrOfPubl.SelectedIndex].ToString();
        }
        private void CityOfPubl_TextChanged(object sender, EventArgs e)
        {
            publ.City = CityOfPubl.Text;
        }
        private void YearGrounds_TextChanged(object sender, EventArgs e)
        {
            publ.YearOfGrounds = YearGrounds.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            FileBook.filebook.pub = publ;
        }
    }
}
