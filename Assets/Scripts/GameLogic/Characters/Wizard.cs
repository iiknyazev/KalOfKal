public class Wizard : ICharacter
{
    public int MoveCount => 3;

    public string Name => "Маг";

    public string Description => "Может один раз за 3 хода призвать три липкие лужи. Призвав новые лужи старые высыхают";

    public IMove Move()
    {
        // логика персонажа
        return new CharacterMove();
    }
}