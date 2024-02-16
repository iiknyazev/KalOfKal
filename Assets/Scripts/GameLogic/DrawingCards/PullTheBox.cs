public class PullTheBox : IDrawingCard
{
    public string Name => "Телекинез";
    public string Description => "Притяни к себе препятствие по одной из осей движения.";
    public DrawingCardRate Rate => DrawingCardRate.Ordinary;

    public IMove Draw()
    {
        // логика розыгрыша данной карты
        return new DrawCardMove();
    }
}