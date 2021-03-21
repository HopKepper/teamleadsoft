using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using VMakarov.SalaryDev.SoftDevCons;

namespace VMakarov.SalaryDev.Domain
{
    public class TeamLead : IWorker
    {
        public readonly int id;
        public readonly string name;
        public readonly string surname;
        public readonly int status = 1;
        public double Salary { get; set; }
        public double LTime { get; set; }
        public int Status
        {
            get { return status; }
        }
        public int ID
        {
            get { return id; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Surname
        {
            get { return surname; }
        }

        public List<IWorker> LeadMembers
        {
            get { return LeadM; }
        }

        List<IWorker> LeadM = new List<IWorker>();
        GeneratorID tl_id = new GeneratorID();

        public TeamLead(double salary, string name, string surname)
        {
            this.Salary = salary;
            this.name = name;
            this.surname = surname;
            id = tl_id.GenerateID(this.status);

        }

        public void LogTime()
        {
            LTime = TimeLogger.FillTime();
        }

        public void AddMembers(List<IWorker> lworker)
        {
            foreach (var worker in lworker)
            {
                LeadM.Add(worker);
            }
        }

        public void RemoveMember(IWorker worker)
        {
            try
            {
                LeadM.Remove(worker);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ShowAll(List<IWorker> lworker)
        {
            foreach (var worker in lworker)
            {
                Console.WriteLine(worker.Name);
                Console.WriteLine(worker.Surname);
                Console.WriteLine(worker.Salary);
            }
        }

        public void CalculateSalary(List<IWorker> lworker)
        {
            foreach (var worker in lworker)
            {
                double paid = worker.LTime * worker.Salary;
                Console.WriteLine("{0} {1} have {2} per this month. \n", worker.Name, worker.Surname, paid);
            }
        }

        public async void ReadMeetingReview()
        {
            using (StreamReader sr = new StreamReader(@"E:\vsproj\Salary\review.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    await Task.Delay(20000);
                    Console.WriteLine(line);
                }
            }
        }
    }
}
