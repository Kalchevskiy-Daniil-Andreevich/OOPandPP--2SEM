using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1._1
{
    internal class Animal
    {
        private const string Family = "Кошачьи";
        public const string Genus = "Эукариоты";
        protected const string View = "Хищник";
        private string? Height;
        public string? Vision;
        protected string? Weight;
        private int Speed { get; set; }
        public string? Name { get; set; }
        protected int Age { get; set; }

        public Animal()
        {
            
        }

        public Animal(string height, string? vision, string? weight, string? name, int speed, int age)
        {
            Height = height;
            Vision = vision;
            Weight = weight;
            Name = name;
            Speed = speed;
            Age = age;
        }
        public Animal(Animal animal)
        {
            Height = animal.Height;
            Vision = animal.Vision;
            Weight = animal.Weight;
            Name = animal.Name;
            Speed = animal.Speed;
            Age = animal.Age;
        }

        private void GenusAnimal()
        {
            Console.WriteLine(Genus);
        }

        public void InfoLion()
        {
            Console.WriteLine($"Рост льва составляет: {Height}, зрение: {Vision}, вес: {Weight}, имя: {Name}, скорость: {Speed}, возраст: {Age}, семейство: {Family}, род: {Genus}, вид: {View}.");
        }

        protected void FamilyAnimal()
        {
            Console.WriteLine(Family);
        }

    }
}
