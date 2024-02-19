using System.Collections.Generic;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;

public class PlayerNetwork : NetworkBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform spawnedObj;
    //private Transform transformSpawnObj;
    private List<Transform> transformsSpawnedObj;

    private void Start()
    {
        transformsSpawnedObj = new List<Transform>();
    }

    private struct MyCustomData : INetworkSerializable
    {
        public int intValue;
        public bool boolValue;
        public FixedString128Bytes message;

        public void NetworkSerialize<T>(BufferSerializer<T> serializer) where T : IReaderWriter
        {
            serializer.SerializeValue(ref intValue);
            serializer.SerializeValue(ref boolValue);
            serializer.SerializeValue(ref message);
        }
    }


    private NetworkVariable<MyCustomData> netValue = new NetworkVariable<MyCustomData>(
        new MyCustomData
        {
            intValue = 0,
            boolValue = false
        },
        NetworkVariableReadPermission.Everyone, 
        NetworkVariableWritePermission.Owner);

    public override void OnNetworkSpawn()
    {
        netValue.OnValueChanged += (MyCustomData prevValue, MyCustomData nextValue) =>
        {
            Debug.Log(OwnerClientId + " "
                + netValue.Value.intValue + "; "
                + netValue.Value.boolValue + "; "
                + netValue.Value.message);
        };
    }

    private void Update()
    {
        if (!IsOwner) return;

        if (Input.GetKeyUp(KeyCode.Q)) TestServerRpc();
        if (Input.GetKeyUp(KeyCode.W)) TestClientRpc();
        if (Input.GetKeyUp(KeyCode.E))
        {
            netValue.Value = new MyCustomData
            {
                intValue = Random.Range(0, 100),
                boolValue = true,
                message = "«¿Ã¿… Õ¿¬—≈√ƒ¿, «¿Ã¿… Õ¿¬≈ ¿!!!"
            };
        }
        if (Input.GetKeyUp(KeyCode.R) && IsServer)
        {
            //var transformSpawnObj = Instantiate(
            //    spawnedObj,
            //    new Vector3(Random.Range(0, 8),
            //    Random.Range(-5, 5), 0), Quaternion.identity);
            //transformSpawnObj.GetComponent<NetworkObject>().Spawn(true);

            //transformsSpawnedObj.Add(transformSpawnObj);
            transformsSpawnedObj.Add(Instantiate(
                spawnedObj,
                new Vector3(Random.Range(0, 8),
                Random.Range(-5, 5), 0), Quaternion.identity));
            transformsSpawnedObj[transformsSpawnedObj.Count - 1].GetComponent<NetworkObject>().Spawn(true);
        }
        if (Input.GetKeyUp(KeyCode.T) && IsServer)
        {
            var randomObjIndex = Random.Range(0, transformsSpawnedObj.Count);
            var obj = transformsSpawnedObj[randomObjIndex].gameObject;
            Destroy(obj);
            transformsSpawnedObj.RemoveAt(randomObjIndex);
        }

        Vector3 moveDir = Vector3.zero;

        //moveDir = Input.inputString switch
        //{
        //    "a" => Vector3.left,
        //    "d" => Vector3.right,
        //    "w" => Vector3.up,
        //    "s" => Vector3.down,
        //    _ => moveDir
        //};

        if (Input.GetKey(KeyCode.A)) moveDir.x += -1f;
        if (Input.GetKey(KeyCode.D)) moveDir.x += 1f;
        if (Input.GetKey(KeyCode.W)) moveDir.y += 1f;
        if (Input.GetKey(KeyCode.S)) moveDir.y += -1f;

        transform.position += moveDir * moveSpeed * Time.deltaTime; 
    }

    [ServerRpc]
    private void TestServerRpc()
    {
        Debug.Log("TestServerRpc " + OwnerClientId);
    }

    [ClientRpc]
    private void TestClientRpc()
    {
        Debug.Log("TestClientRpc " + OwnerClientId);
    }
}
