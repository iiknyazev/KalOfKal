public enum CellType
{
    Obstacle,
    Empty,
    Star,
    Dynamite,
    PortalGate,
    Piston,
    Mucus
}

public interface ICell : IFieldItem
{
    public CellType CellType { get; }
}