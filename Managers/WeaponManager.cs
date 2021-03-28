using ItemManagerSystem.GameObjects;
using ItemManagerSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemManagerSystem.Managers
{
    public static class WeaponManager
    {
        public static void CreateItems()
        {
            Longsword longsword = new Longsword();

            
        }

        public static void PrintWeapon<T>(int objectId, T attributeType)
        {
            var item = ItemManager.GetItem<IItem>(objectId);
        }

    }
}
