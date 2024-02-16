using Newtonsoft.Json;

public class Star : ICell
{
    [JsonIgnore]
    public string Name => "Звезда";
    [JsonIgnore]
    public string Description => "За звёзды можно купить артефакты в магазине. Каком магазине? Кажд... *не слышно*.";
    public CellType CellType => CellType.Star;
}