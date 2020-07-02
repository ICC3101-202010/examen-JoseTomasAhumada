using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public abstract class Person
    {
        private string name;
        private int age;
        private string nation;
        private int salary;
        public Person(string name, int age, string nation, int salary)
        {
            this.name = name;
            this.age = age;
            this.nation = nation;
            this.salary = salary;
        }
        public string GetName()
        {
            return name;
        }
        public int GetAge()
        {
            return age;
        }
        public string GetNation()
        {
            return nation;
        }
        public int GetSalary()
        {
            return salary;
        }
    }
}
