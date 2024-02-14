public class PullTheBox : IDrawingCard
{
    public string Name => "Телекинез";
    public string Description => "Притяни к себе препятствие по одной из осей движения.";
    public DrawingCardRate Rate => DrawingCardRate.Ordinary;

    public void Draw()
    {
        throw new System.NotImplementedException();
    }
}