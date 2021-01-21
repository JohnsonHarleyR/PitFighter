using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    // The blueprint for each weapon type
    interface IWeapon
    {
        public bool outcomeBow();
        public bool outcomeSpear();
        public bool outcomeSword();
        public bool outcomeHammer();
        public bool outcomeDagger();

    }
}
