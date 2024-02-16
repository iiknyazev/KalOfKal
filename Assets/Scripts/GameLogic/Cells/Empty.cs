using Newtonsoft.Json;

public class Empty : ICell
{
    [JsonIgnore]
    public string Name => "Пустая клетка"; 
    [JsonIgnore]
    public string Description => "Совершенно беспонтовая клетка.";
    public CellType CellType => CellType.Empty;
}