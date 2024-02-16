using UnityEngine;

public class CellClickHandler : MonoBehaviour
{
    public static string KeyPressedString { get; private set; }

    private void OnMouseDown()
    {
        gameObject.GetComponent<SpriteRenderer>().color = KeyPressedString switch
        {
            "1" => CellColorManager.ObstacleColor,
            "2" => CellColorManager.EmptyColor,
            "3" => CellColorManager.StarColor,
            "4" => CellColorManager.PistonColor,
            "5" => CellColorManager.DynamiteColor,
            "6" => CellColorManager.PortalGateColor,
            "7" => CellColorManager.MucusColor,
            _ => gameObject.GetComponent<SpriteRenderer>().color
        };
    }

    private void Start()
    {
        KeyPressedString = "1";
    }

    private void Update()
    {
        KeyPressedString = Input.inputString switch
        {
            "1" => "1",
            "2" => "2",
            "3" => "3",
            "4" => "4",
            "5" => "5",
            "6" => "6",
            "7" => "7",
            _ => KeyPressedString
        };
    }
}
