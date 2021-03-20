using System;
using System.Collections.Generic;
using System.Text;
using VMakarov.SalaryDev.SoftDevCons;

namespace VMakarov.SalaryDev.Domain
{
    public class Freelancer : IWorker
    {
        public readonly int id;
        public readonly string name;
        public readonly string surname;
        public readonly int status = 3;
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

        List<Employer> EmpLead = new List<Employer>();
        IGeneratorID tl_id = new GeneratorID();

        public Freelancer(double salary, string name, string surname)
        {
            this.Salary = salary;
            this.name = name;
            this.surname = surname;
            id = tl_id.GenerateID(status);
        }

        public void LogTime()
        {
            LTime = TimeLogger.FillTime();
        }
    }
}
