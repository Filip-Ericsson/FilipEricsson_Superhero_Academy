using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAcademy
{
    class Druid : Superhero
    {

        string classTitle = "The Druid";

        int druidDmgModifier = 1;

        public int thorns()
        {
            return dmg + druidDmgModifier;
        }

        public int snaringDrain()
        {
            restoreHealth(druidDmgModifier);

            return dmg - druidDmgModifier;
        }

        public string getName()
        {
            return name + classTitle;
        }

        public override void restoreHealth(int amountToRestore)
        {
            base.restoreHealth(amountToRestore *2);
        }
    }
}
