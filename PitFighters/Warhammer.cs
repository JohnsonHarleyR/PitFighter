using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    class Warhammer : IWeapon
    {
        // player 1 here should refer to the player holding this weapon

        readonly private string name;

        public Warhammer() { }

        public Warhammer(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public int OutcomeBow()
        {
            return 2; // bow wins - player 2
        }

        public int OutcomeDagger()
        {
            return 1; // warhammer wins - player 1
        }

        public int OutcomeHammer()
        {
            return 0; // warhammer - tie
        }

        public int OutcomeSpear()
        {
            return 2; // spear wins - player 2
        }

        public int OutcomeSword()
        {
            return 1; // warhammer wins - player 1
        }
    }
}
