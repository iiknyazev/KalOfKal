public class Wizard : ICharacter
{
    public int MoveCount => 3;

    public string Name => "Маг";

    public string Description => throw new System.NotImplementedException();

    public IFieldItem[,] Move()
    {
        throw new System.NotImplementedException();
    }
}