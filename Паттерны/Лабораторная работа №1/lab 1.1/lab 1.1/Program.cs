using lab_1._1;
using System.Security.Principal;

namespace lab1_1
{
    class Program
    {
        static void Main(string[] args) 
        { 
            Animal animal = new Animal("110", "Отличное", "190", "Муфаса", 80, 10);
            animal.InfoLion();
            //animal.GenusAnimal();
            //animal.FamilyAnimal();

            Animal2_0 animal2 = new Animal2_0("6 метров", "острое", "2000 кг", "Джулиан", 30, 8, "Индия");
            animal2.InfoGiraffe();

            IAbilities abilities = new Animal2_0();
            abilities.AbilityAnimal();

            abilities[2] = 14;

            Console.WriteLine("Возможные года жизни львов: ");

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(abilities[i]);
            }

            Bitchwolf bitchwolf = new Bitchwolf("8 лет", "Серая шерсть", "12 кг") { Weight = "от 20 до 50 кг" };
            bitchwolf.InfoWeight();
            bitchwolf.InfoBitchwolf();
        }
    }
}