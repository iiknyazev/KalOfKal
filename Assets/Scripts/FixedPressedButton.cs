using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))] // условие, что на объекте есть компонент Button
public class FixedPressedButton : MonoBehaviour
{
    public void FixedMethod()
    {
        var button = GetComponent<Button>();
        button.interactable = false;
        button.interactable = true;
    }
}