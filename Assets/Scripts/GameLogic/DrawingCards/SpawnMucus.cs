public class SpawnMucus : IDrawingCard
{
    public string Name => "Куда смотрит ЖКХ?";
    public string Description => "На выбранную клетку прольётся лужа слизи.";
    public DrawingCardRate Rate => DrawingCardRate.Epic;

    public void Draw()
    {
        throw new System.NotImplementedException();
    }
}