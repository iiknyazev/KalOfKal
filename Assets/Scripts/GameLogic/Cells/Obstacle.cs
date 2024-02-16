using Newtonsoft.Json;

public class Obstacle : ICell
{
    [JsonIgnore]
    public string Name => "Препятствие";
    [JsonIgnore]
    public string Description => "Просто препятствие. Через него не пройти. Если только не...";
    public CellType CellType => CellType.Obstacle;
}