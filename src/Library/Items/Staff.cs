namespace RoleplayGame
{
    public class Staff: IAttackItem, IDefenseItem
    {
        public int AttackValue 
        {
            get
            {
                return 100;
            }
            set
            {
                this.AttackValue= 3*this.AttackValue/2;
            }
        }

        public int DefenseValue
        {
            get
            {
                return 100;
            }
            set
            {
                this.DefenseValue= 3*this.DefenseValue/2;
            }
        }
        public int EnchantmentCost
        {
            get
            {
                return 500;
            }
        }
    }
}