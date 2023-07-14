using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1._1
{
    internal interface IAbilities
    {
        public string Habiat { get; set; }    
        public void AbilityAnimal();

        public event EventHandler? Ready;

        int this[int index]
        {
            get;
            set;
        }
    }
}
