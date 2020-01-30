using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAcademy
{
    class Superhero
    {
        protected string name = "";
        protected int health = 100;
        protected bool isDead;
        protected int dmg =5;
        int exp = 0;
        int level = 0;


        public virtual void takeDmg(int dmgTaken)
        {
            health -= dmgTaken;
        }

        public virtual void restoreHealth(int amountToRestore)
        {
            health += amountToRestore;
        }

        public int attack()
        {
            return dmg;
        }
        public void increaseExp(int expToAdd)
        {
            exp += expToAdd;
            level = 1 + exp / 100;
        }
    }
}
