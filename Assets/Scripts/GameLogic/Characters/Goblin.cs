public class Goblin : ICharacter
{
    public int MoveCount => 3;

    public string Name => "Гоблин";

    public string Description => throw new System.NotImplementedException();
    public IFieldItem[,] Move()
    {
        throw new System.NotImplementedException();
    }
}