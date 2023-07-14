using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабораторная_работа___2
{
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }
        public static Authors authors = new Authors();
        private void OtchestvoAuthor_TextChanged(object sender, EventArgs e)
        {
            authors.OtchestvoAuthor = OtchestvoAuthor.Text;
        }
        private void CountryAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            authors.Country = CountryAuthor.Items[CountryAuthor.SelectedIndex].ToString();
        }
        private void InfoID_TextChanged(object sender, EventArgs e)
        {
            authors.Id = InfoID.Text;
        }
        private void ReadyButton_Click(object sender, EventArgs e)
        {
            this.Close();
            FileBook.filebook.author = authors;
        }
        private void NumberPassport_TextChanged(object sender, EventArgs e)
        {   
                authors.NubmerPassport = NumberPassport.Text;
                var passport = System.Text.RegularExpressions.Regex.IsMatch(NumberPassport.Text, @"^[A-Z]{2}\d{6}$");
                label5.Text = passport.ToString();  
        }
    }
}
