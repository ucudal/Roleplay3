namespace RoleplayGame
{
    public class Axe: IAttackItem
    {
        public int AttackValue 
        {
            get
            {
                return 25;
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