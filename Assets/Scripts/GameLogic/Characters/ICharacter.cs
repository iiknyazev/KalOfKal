public interface ICharacter : IFieldItem
{
    int MoveCount { get; }

    IFieldItem[,] Move();
}