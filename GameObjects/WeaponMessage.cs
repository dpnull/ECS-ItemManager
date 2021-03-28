using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemManagerSystem.GameObjects
{
    public class WeaponMessage
    {
        public int MinDamage;
        public int MaxDamage;

        public WeaponMessage(int minDamage, int maxDamage)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }
    }
}
