using Newtonsoft.Json;

public class Dynamite : ICell
{
    [JsonIgnore]
    public string Name => "BOOM!";
    [JsonIgnore]
    public string Description => "В конце хода он взрывается. Все разрушенные стены станут звёздами.";

    public CellType CellType => CellType.Dynamite;
}