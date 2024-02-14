using UnityEngine;

public class TestScript : MonoBehaviour
{
    public void Start()
    {
        var deck = new Deck();
        var shop = Shop.Instance.GenerateArtifacts(3);
    }
}