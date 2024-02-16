using Newtonsoft.Json;

public class Mucus : ICell
{
    [JsonIgnore]
    public string Name => "Лужа слизи";
    [JsonIgnore]
    public string Description => "Игрок попавший на эту клетку застревает на ней, передавая ход оппоненту.";
    public CellType CellType => CellType.Mucus;
}