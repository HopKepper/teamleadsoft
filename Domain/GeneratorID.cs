using System;
using System.Collections.Generic;
using System.Text;
using VMakarov.SalaryDev.SoftDevCons;

namespace VMakarov.SalaryDev.Domain
{
    class GeneratorID : IGeneratorID
    {
        public int GenerateID(int status)
        {
            // If the id is repeated, then the workers are lucky and they will receive a surprise from the team
            switch (status)
            {
                case 1: return new Random().Next(1, 200);
                case 2: return new Random().Next(201, 1000);
                case 3: return new Random().Next(1000, 2000);
                default: return 0;
            }
        }
    }
}
