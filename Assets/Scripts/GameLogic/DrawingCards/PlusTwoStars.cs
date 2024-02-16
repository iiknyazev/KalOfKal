public class PlusTwoStars : IDrawingCard
{
    public string Name => "Деньги мне плати";
    public string Description => "Получи две звезды.";
    public DrawingCardRate Rate => DrawingCardRate.Epic;

    public IMove Draw()
    {
        // логика розыгрыша данной карты
        return new DrawCardMove();
    }
}