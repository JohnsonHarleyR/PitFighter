using System;
using System.Collections.Generic;
using System.Text;

namespace PitFighters
{
    class SwordShield : IWeapon
    {
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

        public bool OutcomeBow()
        {
            throw new NotImplementedException();
        }

        public bool OutcomeDagger()
        {
            throw new NotImplementedException();
        }

        public bool OutcomeHammer()
        {
            throw new NotImplementedException();
        }

        public bool OutcomeSpear()
        {
            throw new NotImplementedException();
        }

        public bool OutcomeSword()
        {
            throw new NotImplementedException();
        }
    }
}
