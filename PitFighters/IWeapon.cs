using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    // The blueprint for each weapon type
    interface IWeapon
    {

        // If it returns 1, player 1 wins battle
        // If it returns 2, player 2 wins battle
        // If it returns 0, both players lose

        public int OutcomeBow();
        public int OutcomeSpear();
        public int OutcomeSword();
        public int OutcomeHammer();
        public int OutcomeDagger();

        public string GetName();

    }
}
