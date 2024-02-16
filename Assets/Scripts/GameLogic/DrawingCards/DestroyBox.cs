public class DestroyBox : IDrawingCard
{
    public string Name => "Дайте пройти!";
    public string Description => "Уничтожь одно препятствие.";
    public DrawingCardRate Rate => DrawingCardRate.Ordinary;

    public IMove Draw()
    {
        // логика розыгрыша данной карты
        return new DrawCardMove();
    }
}