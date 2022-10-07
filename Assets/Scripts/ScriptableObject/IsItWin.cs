using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IsItWin", menuName = "ScriptableObjects/Win", order = 3)]

public class IsItWin : ScriptableObject, ISerializationCallbackReceiver
{
    public bool moduleAtGoodPlace;
    public bool scdModuleAtGoodPlace;
    public bool characterAtGoodPlace;
    public float actionRestante;
    public bool allowMovementToCheckpoint;

    public void OnAfterDeserialize()
    {
        moduleAtGoodPlace = false;
        scdModuleAtGoodPlace = false;
        characterAtGoodPlace = false;
    }

    public void OnBeforeSerialize()
    {

    }

}
