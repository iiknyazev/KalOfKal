public class PutTheBox : IDrawingCard
{
    public string Name => "НА н_Х!";
    public string Description => "Установи одно препятствие.";
    public DrawingCardRate Rate => DrawingCardRate.Rare;

    public void Draw()
    {
        throw new System.NotImplementedException();
    }
}