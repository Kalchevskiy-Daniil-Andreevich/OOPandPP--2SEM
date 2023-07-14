using lab_2;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Organization organization = new Organization("ЗенВиС", "ЗенВ", "ул.Багушевича");
            organization.printInfo();
            University university = new University("Белорусский Государственный Технологический Университет", "БГТУ", "ул.Кирова");
            university.printInfo();
            Faculty faculties = new Faculty("Информационные технологии", "ФИТ", "ул.кирова");
            faculties.printInfo();
            Department departments = new Department();
        }
    }
}