using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class ServerSample : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SendData sendData = new SendData()
        {
            value = Random.Range(0, 10)
        };
        NetworkServer.SendToAll(sendData);
    }
}
