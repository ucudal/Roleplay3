namespace RoleplayGame
{
    public interface ISpell : IMagicalItem
    {
        int AttackValue { get; }

        int DefenseValue { get; }
    }
}