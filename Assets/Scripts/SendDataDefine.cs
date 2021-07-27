using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Mirror;

[System.Serializable]
public struct SendData : NetworkMessage
{
    public int value;
}