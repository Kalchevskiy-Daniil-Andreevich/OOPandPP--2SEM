using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace lab_1._1
{
    internal class Animal2_0 : IAbilities
    {
        private const string Family = "Кошачьи";
        public const string Genus = "Эукариоты";
        protected const string View = "Домашние животные";
        private string? Height;
        public string? Vision;
        protected string? Weight;
        public string? Name { get; set; }
        private int Speed { get; set; }
        protected int Age { get; set; }

        public Animal2_0()
        {

        }

        public Animal2_0(string height, string? vision, string? weight, string? name, int speed, int age, string habiat)
        {
            Height = height;
            Vision = vision;
            Weight = weight;
            Name = name;
            Speed = speed;
            Age = age;
            Habiat = habiat;
        }

        public Animal2_0(Animal2_0 abilities)
        {
            Height = abilities.Height;
            Vision = abilities.Vision;
            Weight = abilities.Weight;
            Name = abilities.Name;
            Speed = abilities.Speed;
            Age = abilities.Age;
            Habiat = abilities.Habiat;
        }

        private void GenusAnimal()
        {
            Console.WriteLine(Genus);
        }

        public void InfoLion()
        {
            Console.WriteLine($"Рост льва составляет: {Height}, зрение: {Vision}, вес: {Weight}, имя: {Name}, скорость: {Speed}, возраст: {Age};");
        }

        protected void FamilyAnimal()
        {
            Console.WriteLine(Family);
        }

        private string? habiat;
        public string? Habiat
        {
            get
            {
                return habiat;
            }
            set
            {
                if (value == "Африка" || value == "Индия" || value == "Южная часть Африка")
                    habiat = value;
                else
                    throw new ArgumentException("Жирафов в этом ареале обитания не существует");
            }
        }

        void IAbilities.AbilityAnimal()
        {
            Console.WriteLine($"Львы способны развивать скорость до 80 км/ч, также они обладают рыком.");
        }

        public event EventHandler? Ready;
        event EventHandler? IAbilities.Ready
        {
            add
            {
                Ready += value;
            }
            remove 
            { 
                Ready -= value;
            }
        }

        private int[] ageLion = new int[] { 10, 12, 30 };

        public int this[int index]
        {
            set
            {
                ageLion[index] = value;
            }
            get
            {
                return ageLion[index];
            }
            //с помощью индексатора мы можем индексировать объекты классов и обращаться к объектам класса также как и к массиву
            //индексатор работает с массивами
        }
        public void InfoGiraffe()
        {
            Console.WriteLine($"Информацию о жирафе: {Height}, {Vision}, {Weight}, {Name}, {Speed}, {Age}, {Habiat}");
        }
    }
}
