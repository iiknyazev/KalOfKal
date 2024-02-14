public class Orc : ICharacter
{
    public int MoveCount => 3;

    public string Name => "Орк";

    public string Description => throw new System.NotImplementedException();

    public IFieldItem[,] Move()
    {
        throw new System.NotImplementedException();
    }
}