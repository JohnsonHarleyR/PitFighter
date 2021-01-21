using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    // The blueprint for each weapon type
    interface IWeapon
    {
        bool outcomeBow();
        bool outcomeSpear();
        bool outcomeSword();
        bool outcomeHammer();
        bool outcomeDagger();

    }
}
