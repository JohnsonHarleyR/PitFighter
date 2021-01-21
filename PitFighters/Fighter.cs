using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    // This defines the fighter and what sort of weapon they hold
    class Fighter
    {
        string Name { get; set; }
        IWeapon Weapon { get; set; }


        // Initializers
        public Fighter() { }
        public Fighter(string name, string type)
        {
            this.Name = name;

            // find out what type of weapon before setting it
            if (type.Equals("Crossbow"))
            {
                Weapon = new Crossbow();
            }
            else if (type.Equals("Spear"))
            {
                Weapon = new Spear();
            }
            else if (type.Equals("Sword & Shield"))
            {
                Weapon = new SwordShield();
            }
            else if (type.Equals("Warhammer"))
            {
                Weapon = new Warhammer();
            }
            else if (type.Equals("Dagger"))
            {
                Weapon = new Dagger();
            }
        }

    }
}
