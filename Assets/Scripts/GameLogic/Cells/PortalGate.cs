using Newtonsoft.Json;

public class PortalGate : ICell
{
    [JsonIgnore]
    public string Name => "Портал";
    [JsonIgnore]
    public string Description => "Догадайся сам , что делает.";
    public CellType CellType => CellType.PortalGate;
}