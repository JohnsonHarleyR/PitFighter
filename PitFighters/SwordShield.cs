using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    class SwordShield : IWeapon
    {

        // player 1 here should refer to the player holding this weapon

        readonly private string name;

        public SwordShield() { }

        public SwordShield(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public int OutcomeBow()
        {
            return 1; // sword wins - player 1
        }

        public int OutcomeDagger()
        {
            return 2; // dagger wins - player 2
        }

        public int OutcomeHammer()
        {
            return 2; // warhammer wins - player 2
        }

        public int OutcomeSpear()
        {
            return 1; // sword wins - player 1
        }

        public int OutcomeSword()
        {
            return 0; // both die - tie
        }
    }
}
