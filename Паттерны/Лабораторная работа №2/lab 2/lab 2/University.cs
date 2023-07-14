using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class University : Organization, IStaff
    {
        protected List<Faculty> faculties;
        public University()
        {

        }
        public University(University university) : base(university)
        {

        }
        public University(string name, string shortName, string address) : base(name, shortName, address)
        {

        }
        public int addFaculty(Faculty faculty)
        {
            int rc = 1;
            return rc;
        }
        public bool delFaculty(int id)
        {
            bool rc = true;
            return rc;
        }
        public bool updFaculty(Faculty faculty)
        {
            bool rc = true;
            return rc;
        }
        private bool verFaculty(Faculty faculty)
        {
            bool rc = true;
            return rc;
        }
        public List<Faculty> getFaculties()
        {
            return this.faculties;
        }
        public override void printInfo()
        {
            Console.WriteLine($"{Name}, {ShortName}, {Address}" );
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
        public Employee recruit(JobVacancy exJ, Person ex)
        {
            return null;
        }
        public void dismiss(int a, Reason ex)
        {

        }
    }
}
