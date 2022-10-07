using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BlockTransformData", menuName = "ScriptableObjects/BlocktransformData", order = 1)]

public class BlockTransformData : ScriptableObject, ISerializationCallbackReceiver
{
    public float transformX;
    public float transformY;
    public float transformZ;
    public bool canMove;
    public bool winPositionFind;

    public bool dragging;

    public void OnAfterDeserialize()
    {
        winPositionFind = false;
    }

    public void OnBeforeSerialize()
    {

    }
}