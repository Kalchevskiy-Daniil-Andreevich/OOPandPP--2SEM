using lab_1;
                         
namespace lab1
{
    class Progaram
    {
        static void Main(string[] args)
        {
            static void DoAction(IInfo iinfo)
            {
                iinfo.Run();
            }

            Tiger tiger = new Tiger(150, "Опасное животное");
            tiger.InfoAnimal();
            tiger.Skin();
            DoAction(tiger);

            Console.WriteLine("\n");

            Lion lion = new Lion(200, "Король зверей");
            lion.InfoAnimal();
            lion.Skin();
            DoAction(lion);
        }
    }
}