public class DestroyBox : IDrawingCard
{
    public string Name => "Дайте пройти";

    public string Description => "Уничтожь одно препятствие";

    public DrawingCardRate Rate => DrawingCardRate.Ordinary;

    public void Draw()
    {
        throw new System.NotImplementedException();
    }
}