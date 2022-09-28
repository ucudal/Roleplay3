using System.Collections.Generic;

namespace RoleplayGame
{
    public class Characters
    {
        public Characters(string name)
        {
            this.Name = name;
        }

        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
            }
        }
        private int health = 100;
        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public virtual int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)    //  Pregunta el tipo --> ¿corregir?
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public virtual int DefenseValue
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
                return value;
            }
        }

        public List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void AttackDodged(Characters defender)
        {
            if (!Luck.Lucky())
            {
                if (defender.DefenseValue < this.AttackValue)
                {
                    defender.Health -= this.AttackValue - defender.DefenseValue;
                }
            }
        }
        public void Attack(Characters defender)
        {
            this.AttackDodged(defender);
            defender.IsAlive();
        }

        public bool IsAlive()
        {
            if (this.Health <= 0)
            {
                this.items = null;
                Transaction(false, this.Coins / 2);
                return false;
            }
            else
            {
                return true;
            }
        }
        public int Coins = 100;
        public bool Transaction(bool operation, int value)
        {
            if (operation)
            {
                this.Coins += value;
                return true;
            }
            else
            {
                if (value < this.Coins) //determina si la operacion es posible
                {
                    this.Coins -= value;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}