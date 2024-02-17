using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))] // �������, ��� �� ������� ���� ��������� Button
public class FixedPressedButton : MonoBehaviour
{
    public void FixedMethod()
    {
        var button = GetComponent<Button>();
        button.interactable = false;
        button.interactable = true;
    }
}