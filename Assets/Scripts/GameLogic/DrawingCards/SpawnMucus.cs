public class SpawnMucus : IDrawingCard
{
    public string Name => "Куда смотрит ЖКХ?";
    public string Description => "На выбранную клетку прольётся лужа слизи.";
    public DrawingCardRate Rate => DrawingCardRate.Epic;

    public IMove Draw()
    {
        // логика розыгрыша данной карты
        return new DrawCardMove();
    }
}