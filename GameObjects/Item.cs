using ItemManagerSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemManagerSystem.Managers;

namespace ItemManagerSystem.GameObjects
{
    public abstract class Item : IItem
    {
        public int ObjectId { get; set; }
        public string Name { get; set; } = "\0";
        //public int Value { get; set; } = 0;
        //public bool CanEquip { get; set; } = false;
        //public bool CanStack { get; set; } = false;
        public List<IAttribute> Components { get; set; } = new List<IAttribute>();

        public Item(string name)
        {
            ItemManager.Add(this);
            ObjectId = ItemManager.GetUniqueId();

            Name = name;    
        }

        public void ReceiveMessage<T>(T message)
        {
            foreach(IAttribute attribute in Components)
            {
                attribute.ReceiveMessage<T>(message);
            }
        }

        public T GetAttribute<T>() where T : IAttribute
        {
            return Components.OfType<T>().FirstOrDefault();
        }
    }
}
