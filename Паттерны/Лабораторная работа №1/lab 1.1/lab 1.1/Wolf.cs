using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1._1
{
    internal class Wolf
    {
        public string Age;
        private string weight = "";
        public string Weight
        {
            get
            {
                return weight; 
            }
            set
            {
                weight = value;
            }
        }
        public Wolf(string age)
        {
            Age = age; 
        }
        public void InfoWeight()
        {
            Console.WriteLine($"Вес волка/волчицы: {weight}");
        }
    }
}
