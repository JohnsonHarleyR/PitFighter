using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    // The blueprint for each weapon type
    interface IWeapon
    {
        public bool OutcomeBow();
        public bool OutcomeSpear();
        public bool OutcomeSword();
        public bool OutcomeHammer();
        public bool OutcomeDagger();

        public string GetName();

    }
}
