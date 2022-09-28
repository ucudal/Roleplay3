namespace RoleplayGame
{
    public class Sword: IAttackItem
    {
        public int AttackValue 
        {
            get
            {
                return 20;
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
                return 30;
            }
        }
    }
}