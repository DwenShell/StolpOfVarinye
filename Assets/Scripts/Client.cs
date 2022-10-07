using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    private float transformX;
    private float transformY;
    private float transformZ;
    public bool isSlave;

    private float playerTransformX;
    private float playerTransformY;
    private float playerTransformZ;

    public BlockTransformData datas; // instance de notre ScriptableObject crée

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            datas.canMove = false;
        }
    }
    private void Update()
    {
        if (isSlave == true)
        {
            if (datas.canMove == true)
            {
                transformX = datas.transformX;
                transformY = datas.transformY;
                transformZ = datas.transformZ;
                transform.localPosition = new Vector3(transformX, transformY, transformZ);
            }
        }
        if (isSlave == false)
        {
            playerTransformX = transform.localPosition.x;
            playerTransformY = transform.localPosition.y;
            playerTransformZ = transform.localPosition.z;

            datas.transformX = playerTransformX;
            datas.transformY = playerTransformY;
            datas.transformZ = playerTransformZ;
            
        }
    }
}
