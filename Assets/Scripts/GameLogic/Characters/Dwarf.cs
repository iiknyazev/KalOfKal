public class Dwarf : ICharacter
{
    public int MoveCount => 3;

    public string Name => "Гном";

    public string Description => "Может один раз за 2 хода разрушить препятствие и получить одну звезду.";

    public IMove Move()
    {
        // логика персонажа
        return new CharacterMove();
    }
}