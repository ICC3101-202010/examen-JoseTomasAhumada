using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    public class Match
    {
        private Team team1;
        private Team team2;
        private int duration;
        private string type;
        public Match(Team team1, Team team2, int duration, string type)
        {
            this.team1 = team1;
            this.team2 = team2;
            this.duration = duration;
            this.type = type;
        }
        public int GetDuration()
        {
            return duration;
        }
        public string Type()
        {
            return type;
        }
        public void CheckTeams()
        {
            if (team1.Type() == team2.Type())
            {
                Console.WriteLine("Ambos equipos que se enfrentan son del mismo tipo");
                type = team1.Type();
            }
            if (team1.Type() != team2.Type())
            {
                Console.WriteLine("Los equipos que se enfrentan no poseen un mismo tipo");
            }
        }
        public void OnInjuredPlayer(object source, EventArgs e)
        {
            Console.WriteLine("El jugador lesionado ha sido cambiado.");
        }
    }
}
