using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class afterCheckpoint : MonoBehaviour
{
    public GameObject checkpointTarget;
    public GameObject nextTarget;

    [SerializeField] private IsItWin datas;

    private void Update()
    {
        if (checkpointTarget.activeInHierarchy == false && datas.moduleAtGoodPlace == true)
            nextTarget.SetActive(true);
    }

}
