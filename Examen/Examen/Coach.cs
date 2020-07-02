using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Coach : Person
    {
        private int tactic;
        public Coach(string name, int age, string nation, int salary, int tactic) : base(name, age, nation, salary)
        {
            this.tactic = tactic;
        }
    }
}
