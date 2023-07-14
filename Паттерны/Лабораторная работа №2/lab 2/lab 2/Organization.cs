using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class Organization : IStaff
    {
        private int id = 0;
        public int Id
        {
            get 
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            protected set
            {
                name = value;
            }
        }
        private string shortName;
        public string ShortName
        {
            get
            {
                return shortName;
            }
            protected set
            {
                shortName = value;
            }
        }
        private string address;
        public string Address
        {
            get
            {
                return address;
            }
            protected set
            {
                address = value;
            }
        }
        private DateTime timeStamp;
        public DateTime TimeStamp
        {
            get
            {
                return timeStamp;
            }
            protected set
            {
                timeStamp = value;
            }
        }
        public Organization() 
        { 
        
        }
        public Organization(Organization organization)
        {
            Name = organization.name;
            ShortName = organization.shortName;
            Address = organization.address;
        }
        public Organization(string name, string shortName, string address)
        {
            Name = name;
            ShortName = shortName;
            Address = address;
        }
        public virtual void printInfo()
        {
            Console.WriteLine($"{Name}, {shortName}, {Address}");
        }

        List<JobVacancy> IStaff.getJobVacancies()
        {
            return null;
        }

        List<Employee> IStaff.getEmployees()
        {
            return null;
        }

        List<JobTitle> IStaff.getJobTitles()
        {
            return null;
        }

        public string printJobVacancies()
        {
            return "";
        }

        int IStaff.addJobTitle(JobTitle jobTitle)
        {
            return 0;
        }

        public bool delJobTitile(int id)
        {
            return false;
        }

        int IStaff.openJobVacancy(JobVacancy jobVacancy)
        {
            throw new NotImplementedException();
        }

        public bool closeJobVacancy(int id)
        {
            return false;
        }

        Employee IStaff.recruit(JobVacancy jobVacancy, Person person)
        {
            return null;
        }

        bool IStaff.dismiss(int id, Reason reason)
        {
            return false;
        }
    }
}
