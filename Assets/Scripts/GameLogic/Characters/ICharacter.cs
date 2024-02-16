public interface ICharacter : IFieldItem
{
    int MoveCount { get; }

    public IMove Move();
}