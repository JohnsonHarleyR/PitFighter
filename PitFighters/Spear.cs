using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    class Spear : IWeapon
    {
        // player 1 here should refer to the player holding this weapon

        readonly private string name;

        public Spear() { }

        public Spear(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public int OutcomeBow()
        {
            return 1; // spear wins - player 1
        }

        public int OutcomeDagger()
        {
            return 2; // dagger wins - player 2
        }

        public int OutcomeHammer()
        {
            return 1; // spear wins - player 1
        }

        public int OutcomeSpear()
        {
            return 0; // both die - tie
        }

        public int OutcomeSword()
        {
            return 2; // sword wins - player 2
        }
    }
}
