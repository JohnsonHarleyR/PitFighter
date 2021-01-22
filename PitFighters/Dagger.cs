using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    class Dagger : IWeapon
    {

        // player 1 here should refer to the player holding this weapon

        readonly private string name;

        public Dagger() { }

        public Dagger(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }

        public int OutcomeBow()
        {
            return 2; // crossbow wins
        }

        public int OutcomeDagger()
        {
            return 0; // tie - both die
        }

        public int OutcomeHammer()
        {
            return 2; // warhammer wins - player 2
        }

        public int OutcomeSpear()
        {
            return 1; // dagger wins - player 1
        }

        public int OutcomeSword()
        {
            return 1; // dagger wins - player 1
        }
    }
}
