using System;
using System.Collections.Generic;
using System.Text;

namespace Salary
{
    class Employer
    {
        public double Salary { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int ID { get; private set; }

        public Employer(double salary, string name, string surname)
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
