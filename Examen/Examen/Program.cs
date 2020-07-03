using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player("nombre1", 1, "s", 11, 13, 13, "0", "arquero");
            Player p2 = new Player("nombre2", 2, "s", 112, 133, 133, "10", "arquero");
            Player p3 = new Player("nombre3", 76, "tr", 643, 65, 3, "23", "delantero");
            List<Player> l = new List<Player>();
            List<Player> l2 = new List<Player>();
            Coach coach = new Coach("entrenador", 23, "s", 23, 33);
            Coach coach2 = new Coach("entrenador2", 23, "tr", 3, 35);
            Medic medic = new Medic("Medico", 34, "s", 543, 5432);
            Medic medic2 = new Medic("Medico2", 34, "tr", 43, 52);
            l.Add(p);
            l.Add(p2);
            l2.Add(p3);
            Team t = new Team("team1", "chilena", l, coach, medic);
            Team t2 = new Team("team2", "argentina", l2, coach2, medic2);
            Match match = new Match(t, t2, 96, "liga");
            
            p.InjuredPlayer += coach.OnInjuredPlayer;
            p.InjuredPlayer += match.OnInjuredPlayer;
            Console.ReadKey();
        }
    }
}
