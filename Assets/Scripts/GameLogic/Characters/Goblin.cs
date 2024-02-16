public class Goblin : ICharacter
{
    public int MoveCount => 3;

    public string Name => "Гоблин";

    public string Description => "Если вокруг стоит 5 коробок в начале хода, то делай 4 передвижения.";
    public IMove Move()
    {
        // логика персонажа
        return new CharacterMove();
    }
}