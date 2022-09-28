namespace RoleplayGame
{
    public class Armor: IDefenseItem
    {
        public int DefenseValue
        {
            get
            {
                return 25;
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
                return 40;
            }
        }
    }
}