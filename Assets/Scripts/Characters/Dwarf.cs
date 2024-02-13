public class Dwarf : ICharacter
{
    public int MoveCount => 3;

    public string Name => throw new System.NotImplementedException();

    public string Description => throw new System.NotImplementedException();

    IFieldItem[,] ICharacter.Move()
    {
        throw new System.NotImplementedException();
    }
}