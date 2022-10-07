using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevel : MonoBehaviour
{

    public GameObject winPlateforme;
    public GameObject scdWinPlateforme;
    public Material newMaterial;
    public bool isLevel3;

    //private Material oldMaterial;

    [SerializeField]
    private IsItWin datas;

    private void Update()
    {
        if (datas.moduleAtGoodPlace == true)
        {
            if(isLevel3 == true)
            {
                MeshRenderer scdMeshRenderer = winPlateforme.GetComponent<MeshRenderer>();

                scdMeshRenderer.material = newMaterial;
            }
            MeshRenderer meshRenderer = winPlateforme.GetComponent<MeshRenderer>();

            meshRenderer.material = newMaterial;
        }

    }
}
