using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelEditorUI : MonoBehaviour
{
    [SerializeField] private Button toMainMenu;
    private void Awake()
    {
        toMainMenu.onClick.AddListener(() => SceneManager.LoadScene(0));
    }
}