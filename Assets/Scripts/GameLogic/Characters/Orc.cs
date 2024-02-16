public class Orc : ICharacter
{
    public int MoveCount => 3;

    public string Name => "Орк";

    public string Description => "Может один раз за ход перепрыгнуть ОДНО препятствие, если это возможно.";

    public IMove Move()
    {
        // логика персонажа
        return new CharacterMove();
    }
}