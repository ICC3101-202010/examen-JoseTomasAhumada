using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Medic : Person
    {
        private int experience;
        public Medic(string name, int age, string nation, int salary, int experience) : base(name, age, nation, salary)
        {
            this.experience = experience;
        }
    }
}
