namespace RoleplayGame
{
    public class Bow: IAttackItem
    {
        public int AttackValue 
        {
            get
            {
                return 15;
            }
            set
            {
                this.AttackValue= 3*this.AttackValue/2;
            }
        }
        public int EnchantmentCost
        {
            get
            {
                return 21;
            }
        }
    }
}