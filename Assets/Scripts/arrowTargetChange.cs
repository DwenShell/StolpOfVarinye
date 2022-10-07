using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowTargetChange : MonoBehaviour
{

    public WhichBlockToMove whichBlockToMove;

    public Client stairClient;
    public Client blockClient;

    public GameObject block;
    public GameObject stair;

    
    private void Update()
    {
        if (whichBlockToMove.Block == block)
        {
            stairClient.enabled = false;
            blockClient.enabled = true;
        }

        if (whichBlockToMove.Block == stair)
        {
            blockClient.enabled = false;
            stairClient.enabled = true;
        }


    }
}
