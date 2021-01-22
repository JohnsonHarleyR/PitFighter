using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    // 0 is tie
    // 1 is player 1 wins
    // 2 is player 2 wins

    class Crossbow : IWeapon
    {
        // player 1 here should refer to the player holding this weapon

        readonly private string name;

        public Crossbow() { }

        public Crossbow(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public int OutcomeBow()
        {
            return 0;
        }

        public int OutcomeDagger()
        {
            return 1; // crossbow wins
        }

        public int OutcomeHammer()
        {
            return 1; // crossbow wins
        }

        public int OutcomeSpear()
        {
            return 2; // spear wins - player 2
        }

        public int OutcomeSword()
        {
            return 2; // swordshield wins - player 2
        }
    }
}

        
