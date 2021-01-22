using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    // This defines the fighter and what sort of weapon they hold
    class Fighter
    {
        private string Name { get; set; }
        private IWeapon Weapon { get; set; }


        // Initializers
        public Fighter() { }
        public Fighter(string name)
        {
            this.Name = name;

            
        }

        // find out the fighter's name
        public string GetName()
        {
            return Name;
        }

        // find out the fighter's weapon
        public string GetWeapon()
        {
            return Weapon.GetName();
        }

        // Get outcome of battle, depending on other fighter's weapon
        public int GetOutcome(Fighter fighter2)
        {
            if (fighter2.GetWeapon().Equals("Crossbow"))
                {
                return Weapon.OutcomeBow();
            } 
            else if (fighter2.GetWeapon().Equals("Spear"))
            {
                return Weapon.OutcomeSpear();
            }
            else if (fighter2.GetWeapon().Equals("Sword & Shield"))
            {
                return Weapon.OutcomeSword();
            }
            else if (fighter2.GetWeapon().Equals("Warhammer"))
            {
                return Weapon.OutcomeHammer();
            }
            else 
            {
                return Weapon.OutcomeDagger();
            }
        }

        // set the fighter's weapon
        public void SetWeapon(string type)
        {
            // find out what type of weapon before setting it
            if (type.Equals("Crossbow"))
            {
                Weapon = new Crossbow(type);
            }
            else if (type.Equals("Spear"))
            {
                Weapon = new Spear(type);
            }
            else if (type.Equals("Sword & Shield"))
            {
                Weapon = new SwordShield(type);
            }
            else if (type.Equals("Warhammer"))
            {
                Weapon = new Warhammer(type);
            }
            else if (type.Equals("Dagger"))
            {
                Weapon = new Dagger(type);
            }
        }

    }
}
