using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WhichBlockToMove", menuName = "ScriptableObjects/WhichBlock", order = 2)]

public class WhichBlockToMove : ScriptableObject, ISerializationCallbackReceiver
{
    public GameObject Block;

    public void setbloc(GameObject bloc)
    {
        Block = bloc;
    }
    public void OnAfterDeserialize()
    {
        Block = null;
    }

    public void OnBeforeSerialize()
    {

    }
}
