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
        public int GetExperience()
        {
            return experience;
        }
        public void Evaluate(Player player)
        {
            if (player.GetLession() == true)
            {
                Console.WriteLine("El jugador " + player.GetName() + " está siendo evaluado por el médico.");
            }
        }
        public void Heal(Player player)
        {
            if (player.GetLession() == true)
            {
                Console.WriteLine("El jugador " + player.GetName() + " está siendo curado por el médico.");
            }
        }
    }
}
