using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1._1
{
    internal class Bitchwolf : Wolf
    {
        public string? Color;
        public string Heart { get; set; }
        public Bitchwolf(string age, string? color, string heart) : base(age)
        {
            Color = color;
            Heart = heart;
        }
        public void InfoBitchwolf()
        {
            Console.WriteLine($"Возраст волчицы: {Age}, цвет: {Color}, вес сердца: {Heart}");
        }
    }
}
