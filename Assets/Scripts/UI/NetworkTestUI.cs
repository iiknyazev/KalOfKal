using Unity.Netcode;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NetworkTestUI : MonoBehaviour
{
    [SerializeField] private Button server;
    [SerializeField] private Button client;
    [SerializeField] private Button host;
    [SerializeField] private Button toMainMenu;
    [SerializeField] private PlayerNetwork playerNetwork;

    private void Awake()
    {
        server.onClick.AddListener(() => NetworkManager.Singleton.StartServer());
        client.onClick.AddListener(() => NetworkManager.Singleton.StartClient());
        host.onClick.AddListener(() => NetworkManager.Singleton.StartHost());
        toMainMenu.onClick.AddListener(() =>
        {
            playerNetwork.Disconnect();
            SceneManager.LoadScene(0);
        });
    }
}
