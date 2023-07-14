using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class Lion : Tiger
    {
        public Lion(int speed, string description) : base(speed, description)
        {

        }

        public override void Skin()
        {
            Console.WriteLine("С гривой");
        }
    }
}
