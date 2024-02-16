using Newtonsoft.Json;

public class Piston : ICell
{
    [JsonIgnore]
    public string Name => "Поршень";
    [JsonIgnore]
    public string Description => "Каждую фазу хода меняет своё состояние. Выдвинут - препятствие, иначе - пустая клетка";
    public CellType CellType => CellType.Piston;
}