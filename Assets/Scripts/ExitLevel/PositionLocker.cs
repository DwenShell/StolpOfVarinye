using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLocker : MonoBehaviour
{

    [SerializeField]
    private IsItWin datas;

    public Rigidbody rb;
    public GameObject Arrow;
    public bool isLevel3;

    public int numBlock = 0;

    private bool touch;

    private void OnTriggerStay(Collider collision)
    {
        Destroy(rb);

        touch = true;
        
    }
    private void Update()
    {
        if (touch==true)
        {
            if (isLevel3 == true)
            {
                if (datas.moduleAtGoodPlace == true)
                {
                    datas.scdModuleAtGoodPlace = true;
                }
            }
            if (isLevel3 == false)
            {
                Arrow.SetActive(false);
            }
            datas.moduleAtGoodPlace = true;
        }
    }

}
