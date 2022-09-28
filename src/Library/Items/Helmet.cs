namespace RoleplayGame
{
    public class Helmet: IDefenseItem
    {
        public int DefenseValue
        {
            get
            {
                return 18;
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
                return 25;
            }
        }
    }
}