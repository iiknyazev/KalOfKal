using System.Collections.Generic;
using System;
using UnityEngine;

public class CellColorManager : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer currentCellSprite;
    [SerializeField]
    private SpriteRenderer obstacleCellSprite;
    [SerializeField]
    private SpriteRenderer emptyCellSprite;
    [SerializeField]
    private SpriteRenderer starCellSprite;
    [SerializeField]
    private SpriteRenderer pistonCellSprite;
    [SerializeField]
    private SpriteRenderer dynamiteCellSprite;
    [SerializeField]
    private SpriteRenderer portalGateCellSprite;
    [SerializeField]
    private SpriteRenderer mucusCellSprite;

    public static Color ObstacleColor { get; private set; }
    public static Color EmptyColor { get; private set; }
    public static Color StarColor { get; private set; }
    public static Color PistonColor { get; private set; }
    public static Color DynamiteColor { get; private set; }
    public static Color PortalGateColor { get; private set; }
    public static Color MucusColor { get; private set; }

    public static Dictionary<Color, IFieldItem> ColorToCell { get; private set; }

    private void Start()
    {
        ObstacleColor = obstacleCellSprite.color;
        EmptyColor = emptyCellSprite.color;
        StarColor = starCellSprite.color;
        PistonColor = pistonCellSprite.color;
        DynamiteColor = dynamiteCellSprite.color;
        PortalGateColor = portalGateCellSprite.color;
        MucusColor = mucusCellSprite.color;

        ColorToCell = new Dictionary<Color, IFieldItem>();
        ColorToCell[ObstacleColor] = new Obstacle();
        ColorToCell[EmptyColor] = new Empty();
        ColorToCell[DynamiteColor] = new Dynamite();
        ColorToCell[PistonColor] = new Piston();
        ColorToCell[PortalGateColor] = new PortalGate();
        ColorToCell[StarColor] = new Star();
        ColorToCell[MucusColor] = new Mucus();
    }

    private void Update()
    {
        currentCellSprite.color = CellClickHandler.KeyPressedString switch
        {
            "1" => ObstacleColor,
            "2" => EmptyColor,
            "3" => StarColor,
            "4" => PistonColor,
            "5" => DynamiteColor,
            "6" => PortalGateColor,
            "7" => MucusColor,
            _ => currentCellSprite.color
        };
    }
}