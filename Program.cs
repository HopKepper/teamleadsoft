using System;
using System.Collections.Generic;
using VMakarov.SalaryDev.Domain;

namespace Salary
{
    class Program
    {
        // TODO: Возможность группе возможных будущих сотруднику подать свое "резюме", после чего передать управлению TL, который отберёт сотрудников в свою команду
        static void Main(string[] args)
        {
            TeamLead tl = new TeamLead(20, "Jame", "Felrt");
            tl.ReadMeetingReview();
            IWorker eml_a = new Employer(23, "Alex", "Arak");
            IWorker frl_r = new Freelancer(24, "Rob", "Parker");
            IWorker eml_ar = new Employer(8, "Artur", "Arak");
            IWorker frl_j = new Freelancer(10, "Jony", "Parker");
            IWorker eml_m = new Employer(14, "Memphis", "Arak");
            IWorker frl_e = new Freelancer(4, "Eden", "Parker");

            tl.AddMembers(new List<IWorker>(){tl, eml_a, frl_e, eml_ar, frl_j, frl_r, eml_m});

            foreach (var worker in tl.LeadMembers)
            {
                Console.WriteLine("{0} {1}, please, log your time.", worker.Name, worker.Surname);
                worker.LogTime();
            }

            tl.CalculateSalary(tl.LeadMembers);
            Console.Read();
        }
    }
}
