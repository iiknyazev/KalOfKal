public enum DrawingCardRate
{
    Ordinary = 10,
    Rare = 7,
    Epic = 5,
    Legendary = 3
}

public interface IDrawingCard : ICard
{
    public DrawingCardRate Rate { get; }
    IMove Draw();
}