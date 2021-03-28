using ItemManagerSystem.GameObjects;
using ItemManagerSystem.Interfaces;
using ItemManagerSystem.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemManagerSystem
{
    class Gameloop
    {
        public Item CurrentWeapon { get; set; }

        public Gameloop()
        {
            WeaponManager.CreateItems();
            CurrentWeapon = (Item)ItemManager.GetItem<IItem>(0);
        }

        public void Loop()
        {
            var item = ItemManager.GetItem<IItem>(CurrentWeapon.ObjectId);

            Console.WriteLine(item.Name);

            Console.WriteLine(item.GetAttribute<WeaponAttribute>().MinDamage);
            Console.WriteLine(item.GetAttribute<WeaponAttribute>().MaxDamage);

            WeaponMessage newDamage = new WeaponMessage(10, 15);
            item.ReceiveMessage(newDamage);

            Console.WriteLine(item.GetAttribute<WeaponAttribute>().MinDamage);
            Console.WriteLine(item.GetAttribute<WeaponAttribute>().MaxDamage);

            Console.ReadLine();
        }
    }
}
