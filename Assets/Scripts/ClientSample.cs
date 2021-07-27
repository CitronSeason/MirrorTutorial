using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using System;

public class ClientSample : MonoBehaviour
{
    // Start is called before the first frame update
    [Obsolete]
    void Start()
    {
        NetworkClient.RegisterHandler<SendData>(ReceiveInfo);
    }

    private void ReceiveInfo(SendData receiveData)
    {
        Debug.Log(JsonUtility.ToJson(receiveData));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
