public class PutTheBox : IDrawingCard
{
    public string Name => "НА н_Х!";
    public string Description => "Установи одно препятствие.";
    public DrawingCardRate Rate => DrawingCardRate.Rare;

    public IMove Draw()
    {
        // логика розыгрыша данной карты
        return new DrawCardMove();
    }
}