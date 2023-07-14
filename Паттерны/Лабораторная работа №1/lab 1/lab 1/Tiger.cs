using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    internal class Tiger : IInfo
    {
        public int Speed { get; set; }
        public string Description { get; set; }
        
        public Tiger(int speed, string description)
        {
            Speed = speed;
            Description = description;
        }

        public void InfoAnimal()
        {
            Console.WriteLine($"Скорость: {Speed}, описание: {Description}");
        }

        public void Run()
        {
            Console.WriteLine("Очень быстро бегает!");
        }

        public virtual void Skin()
        {
            Console.WriteLine("Полосатый");
        }
    }
}
