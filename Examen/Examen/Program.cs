using System;
using System.Collections.Generic;
using System.Linq;
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
            List<Player> l = new List<Player>();
            Coach coach = new Coach("entrenador", 23, "s", 23, 33);
            Medic medic = new Medic("Medico", 34, "s", 543, 5432);
            l.Add(p);
            l.Add(p2);
            Team t = new Team("team1", "chilena", l, coach, medic);
            t.CheckNation();
            t.TeamInformation();
            Console.ReadKey();
        }
    }
}
