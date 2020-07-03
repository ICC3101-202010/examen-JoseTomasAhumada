using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Team
    {
        private string name;
        private string type;
        private List<Player> players;
        private Coach coach;
        private Medic medic;
        public Team(string name, string type, List<Player> players, Coach coach, Medic medic)
        {
            this.name = name;
            this.type = type;
            this.players = players;
            this.coach = coach;
            this.medic = medic;
        }
        public string GetName()
        {
            return name;
        }
        public string Type()
        {
            return type;
        }
        public List<Player> GetPlayers()
        {
            return players;
        }
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }
        public bool CheckNation() //Verifica si la nacionalidad de los integrantes corresponde a la del equipo nacional al que pertenecen.
        {
            string nation = "";
            int i = 0;
            if (type != "liga" || type != "Liga" || type != "LIGA")
            {
                foreach (Player player in players)
                {
                    if (i > 0)
                    {
                        if (nation != player.GetNation() || nation != coach.GetNation() || nation != medic.GetNation())
                        {
                            Console.WriteLine("Existen integrantes del equipo que no son de la misma nacionalidad.");
                            return false;
                        }
                    }
                    nation = player.GetNation();
                    i += 1;
                }
                Console.WriteLine("Todos los integrantes del equipo poseen la misma nacionalidad.");
                return true;
            }
            else
            {
                return true;
            }
        }
        public void TeamInformation() //Retorna la información del equipo.
        {
            Console.WriteLine("INFORMACIÓN DEL EQUIPO:");
            Console.WriteLine("\nNombre del equipo: " + name);
            Console.WriteLine("\nTipo de equipo: " + type);
            Console.WriteLine("\nLista de jugadores:");
            Console.WriteLine("NOMBRE EDAD NACIONALIDAD SALARIO($) ATAQUE DEFENSA NÚMERO POSICIÓN");
            foreach (Player player in players)
            {
                Console.WriteLine(player.GetName() + " " + player.GetAge() + " " + player.GetNation() + " " + player.GetSalary() + " " + player.GetAttack() + " " + player.GetDefense() + " " + player.GetNumber() + " " + player.GetPosition());
            }
            Console.WriteLine("\nEntrenador del equipo:");
            Console.WriteLine("NOMBRE EDAD NACIONALIDAD SALARIO TÁCTICA");
            Console.WriteLine(coach.GetName() + " " + coach.GetAge() + " " + coach.GetNation() + " " + coach.GetSalary() + " " + coach.GetTactic());
            Console.WriteLine("\nMédico del equipo:");
            Console.WriteLine("NOMBRE EDAD NACIONALIDAD SALARIO EXPERIENCIA");
            Console.WriteLine(medic.GetName() + " " + medic.GetAge() + " " + medic.GetNation() + " " + medic.GetSalary() + " " + medic.GetExperience());
        }
    }
}
