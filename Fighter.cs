using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAcademy
{
    class Fighter : Superhero
    {

        private string classTitle = "The Fighter";

        int fighterDmgModifyer = 2;


        public int bluntHit()
        {
            return dmg *= fighterDmgModifyer;
        }

        public int piercingStrike()
        {
            return dmg += fighterDmgModifyer;
        }

        public override void takeDmg(int dmgTaken)
        {
            health -= (dmgTaken -3);
        }

        public string getName()
        {
            return name + classTitle;
        }
    }
}
