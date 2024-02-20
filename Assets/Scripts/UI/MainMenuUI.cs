using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private Button toLevelEditor;
    [SerializeField] private Button toNetworkTest;
    [SerializeField] private Button toPVPArena;

    private void Awake()
    {
        toLevelEditor.onClick.AddListener(() => SceneManager.LoadScene(1));
        toNetworkTest.onClick.AddListener(() => SceneManager.LoadScene(2));
        toPVPArena.onClick.AddListener(() => SceneManager.LoadScene(3));
    }
}