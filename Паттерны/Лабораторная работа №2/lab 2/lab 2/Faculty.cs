using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class Faculty : Organization, IStaff
    {
        protected List<Department> departments;
        public Faculty()
        {

        }
        public Faculty(Faculty faculties)
        {

        }
        public Faculty(string name, string shortName, string address) : base(name, shortName, address)
        {

        }
        public int addDepartment(Department departments)
        {
            return 0;
        }
        public bool delDepartment(int id)
        {
            return false;
        }
        public bool updDepartment(Department departments)
        {
            return false;
        }
        private bool verDepartment(Department departments)
        {
            return false;
        }
        public List<Department> getDepartments()
        {
            return departments;
        }
        public override void printInfo()
        {
            Console.WriteLine($"{Name}, {ShortName}, {Address}");
        }
        public List<JobVacancy> getJobVacancies()
        {
            return null;
        }
        public int addJobTitile(JobTitle jobTitle)
        {
            return 0;
        }
        public bool delJobTitile(int id)
        {
            return false;
        }
        public int openJobVacancy(JobVacancy jobVacancy)
        {
            return 0;
        }
        public bool closeJobVacancy(JobVacancy jobVacancy)
        {
            return false;
        }
        public Employee recruit(JobVacancy ex)
        {
            return null;
        }
        public void dismiss(int q, Reason ex)
        {
        }
    }
}
