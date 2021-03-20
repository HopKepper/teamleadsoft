using System;
using System.Collections.Generic;
using System.Text;

namespace VMakarov.SalaryDev.Domain
{
    public class Employer : IWorker  // можно вынести часть полей в абстрактный класс при надобности
    {
        public readonly int id;
        public readonly string name;
        public readonly string surname;
        public readonly int status = 2;
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

        GeneratorID emp_id = new GeneratorID();

        public Employer(double salary, string name, string surname)
        {
            this.Salary = salary;
            this.name = name;
            this.surname = surname;
            this.id = emp_id.GenerateID(this.status);
        }
        public void LogTime()
        {
            LTime = TimeLogger.FillTime();
        }


    }
}
