public class SetDynamite : IDrawingCard
{
    public string Name => "BOOM!";
    public string Description => "Установи динамит. В конце хода он взорвётся. Все разрушенные стены станут звёздами";
    public DrawingCardRate Rate => DrawingCardRate.Legendary;

    public IMove Draw()
    {
        // логика розыгрыша данной карты
        return new DrawCardMove();
    }
}