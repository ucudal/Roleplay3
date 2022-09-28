using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard : Characters, IMagicCharacter
    {
        private int health = 100;

        private List<IMagicalItem> magicalItems = new List<IMagicalItem>();

        public Wizard(string name)
        : base(name)
        {
            this.AddItem(new Staff());
        }

        public override int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)   //  Pregunta el tipo --> ¿corregir?
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalAttackItem) //  Pregunta el tipo --> ¿corregir?
                    {
                        value += (item as IMagicalAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public override int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)   //  Pregunta el tipo --> ¿corregir?
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalDefenseItem)    //  Pregunta el tipo --> ¿corregir?
                    {
                        value += (item as IMagicalDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public void AddMagicalItem(IMagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        public void RemoveMagicalItem(IMagicalItem item)
        {
            this.magicalItems.Remove(item);
        }
        
    }
}