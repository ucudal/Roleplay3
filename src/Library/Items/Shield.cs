namespace RoleplayGame
{
    public class Shield: IDefenseItem
    {
        public int DefenseValue
        {
            get
            {
                return 14;
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
                return 20;
            }
        }
    }
}