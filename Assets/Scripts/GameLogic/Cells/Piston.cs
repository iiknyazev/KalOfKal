public class Piston : ICell
{
    public string Name => "Поршень";

    public string Description => "Каждую фазу хода меняет своё состояние. Выдвинут - препятствие, иначе - пустая клетка";
}