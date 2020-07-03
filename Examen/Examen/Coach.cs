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
        public int GetTactic()
        {
            return tactic;
        }
        public void OnInjuredPlayer(object source, EventArgs e)
        {
            Console.WriteLine("El jugador lesionado se cambió por otro jugador de la banca.");
        }
    }
}
