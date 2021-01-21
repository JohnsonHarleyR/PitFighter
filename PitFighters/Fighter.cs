using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    // This defines the fighter and what sort of weapon they hold
    class Fighter
    {
        string name { get; set; }
        IWeapon weapon { get; set; }


        // Initializers
        public Fighter() { }
        public Fighter(string name, string type)
        {
            this.name = name;

            // find out what type of weapon before setting it
            if (type.Equals("Crossbow"))
            {

            }
            else if (type.Equals("Spear"))
            {

            }
            else if (type.Equals("Sword & Shield"))
            {

            }
            else if (type.Equals("Warhammer"))
            {

            }
            else if (type.Equals("Dagger"))
            {

            }
        }

        // get outcome

    }
}
