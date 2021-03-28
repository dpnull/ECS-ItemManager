using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemManagerSystem.GameObjects
{
    public class Longsword : Item
    {
        public Longsword() : base("Longsword")
        {
            WeaponAttribute longswordAttribute = new WeaponAttribute(this);
            Components.Add(longswordAttribute);
            WeaponMessage longswordMessage = new WeaponMessage(7, 10);
            ReceiveMessage(longswordMessage);
        }
    }
}
