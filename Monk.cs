using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAcademy
{
    class Monk : Superhero
    {
        string classTitle = "The Monk";

        int monkDmgModifier = 3;

        public void calmMind()
        {
            restoreHealth(monkDmgModifier);
        }

        public int chiStrike()
        {
            return dmg + monkDmgModifier;
        }

        public override void restoreHealth(int amountToRestore)
        {
            base.restoreHealth(amountToRestore+ (monkDmgModifier/2));
        }

        public override void takeDmg(int dmgTaken)
        {
            base.takeDmg(dmgTaken - (monkDmgModifier/2));
        }

        public string getName()
        {
            return name + classTitle;
        }
    }
}
