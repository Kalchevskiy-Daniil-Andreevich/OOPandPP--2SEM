using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public interface IStaff
    {
        List<JobVacancy> getJobVacancies();
        List<Employee> getEmployees();
        List<JobTitle> getJobTitles();
        string printJobVacancies();
        int addJobTitle(JobTitle jobTitle);
        bool delJobTitile(int id);
        int openJobVacancy(JobVacancy jobVacancy);
        bool closeJobVacancy(int id);
        Employee recruit(JobVacancy jobVacancy, Person person);
        bool dismiss(int id, Reason reason);

    }
}
