using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllowSashaMovement : MonoBehaviour
{
    [SerializeField]
    private IsItWin winCondition;

    public Camera cam;
    public GameObject movementTarget;
    public bool someWhereACheckPoint;
    private bool allowMovementToDoor = true;
    Touch touch;
    Vector3 pos;

    private bool goOnCheckpoint;

    void Update()
    {
        
        if (Input.touchCount != 0)
        {
            touch = Input.touches[0];
            pos = touch.position;
        }
        /*if (someWhereACheckPoint == true)
        {
            allowMovementToDoor = false;
            if (goOnCheckpoint == true)
            {
                allowMovementToDoor = true;
            }
        }*/

        if (touch.phase == TouchPhase.Began)
        {
            //Debug.Log("SachaMovementTouch");
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(pos);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "door" && winCondition.moduleAtGoodPlace == true/* && allowMovementToDoor == true*/)
                {
                    if (winCondition.actionRestante > 0)
                    {
                        OneTimeVariableUpdate();
                        movementTarget.SetActive(true);
                    }
                }
                if (hit.collider.tag == "checkPoint" && winCondition.allowMovementToCheckpoint == true)
                {
                    if (winCondition.actionRestante > 0)
                    {
                        OneTimeVariableUpdate();
                        goOnCheckpoint = true;
                        movementTarget.SetActive(true);
                    }
                }
            }
        }
    }
    private void OneTimeVariableUpdate()
    {
        winCondition.actionRestante -= 1;
    }
}
