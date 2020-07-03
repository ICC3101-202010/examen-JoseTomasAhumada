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
        private bool lession = false;
        //Evento para el cambio de jugador que se lesionó.
        public delegate void InjureplayerEventHandler(object source, EventArgs args);
        public event InjureplayerEventHandler InjuredPlayer;
        protected virtual void OnInjuredplayer()
        {

        }
        public Player(string name, int age, string nation, int salary, int attack, int defense, string number, string position) : base(name, age, nation, salary)
        {
            this.attack = attack;
            this.defense = defense;
            this.number = number;
            this.position = position;
        }
        public int GetAttack()
        {
            return attack;
        }
        public int GetDefense()
        {
            return defense;
        }
        public string GetNumber()
        {
            return number;
        }
        public string GetPosition()
        {
            return position;
        }
        public bool GetLession()
        {
            return lession;
        }
    }
}
