public class PlusTwoStars : IDrawingCard
{
    public string Name => "Деньги мне плати";
    public string Description => "Получи две звезды.";
    public DrawingCardRate Rate => DrawingCardRate.Epic;

    public void Draw()
    {
        throw new System.NotImplementedException();
    }
}