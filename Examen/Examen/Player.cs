using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Player : Person
    {
        private int attack;
        private int defense;
        private string number;
        private string position;
        public Player(string name, int age, string nation, int salary, int attack, int defense, string number, string position) : base(name, age, nation, salary)
        {
            this.attack = attack;
            this.defense = defense;
            this.number = number;
            this.position = position;
        }
    }
}
