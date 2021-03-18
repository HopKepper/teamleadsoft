using System;
using System.Collections.Generic;
using System.Text;

namespace Salary
{
    class TeamLead
    {
        public double Salary { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int ID { get; private set; }

        List<Employer> EmpLead = new List<Employer>();

        public TeamLead(double salary, string name, string surname)
        {
            this.Salary = salary;
            this.Name = name;
            this.Surname = surname;
            this.ID = GenerateID();
        }

        int GenerateID()
        {
            Random id = new Random();
            return id.Next(1, 10000);
        }
    }
}
