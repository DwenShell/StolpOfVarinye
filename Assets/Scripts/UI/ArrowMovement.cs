using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public string draggingTag;
    public Camera cam;
    public Vector3 worldPos;
    public GameObject Arrow;
    public float Speed;

    [SerializeField] private AnimationCurve curve;

    Vector3 StartPos;
    Vector3 EndPos;
    Vector3 pos;
    Touch touch;
    private float time = 0;
    private bool allowMovement = true;

    private GameObject BlockToMove;

    [SerializeField]
    private WhichBlockToMove datas;
    [SerializeField]
    private IsItWin winCondition;

    void Update()
    {
        if (winCondition.actionRestante <= 0)
            return;

        if (Input.touchCount !=0)
        {
            touch = Input.touches[0];
            pos = touch.position;
        }
        if (touch.phase == TouchPhase.Began)
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(pos);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == draggingTag)
                {
                    datas.setbloc(hit.transform.gameObject);
                    BlockToMove = datas.Block;
                    if (winCondition.actionRestante > 0)
                        Arrow.SetActive(true);
                }
                if (allowMovement == true && BlockToMove != null)
                {
                    Debug.Log("f");
                    StartPos = BlockToMove.transform.position;
                    EndPos = StartPos;
                    time = 0;
                    if (hit.collider.name == "UpArrow")
                    {
                        EndPos.y = EndPos.y + 2;
                        OneTimeVariableUpdate();
                    }
                    if (hit.collider.name == "DownArrow")
                    {
                        EndPos.y = EndPos.y - 2;
                        OneTimeVariableUpdate();
                    }
                    if (hit.collider.name == "RightArrow")
                    {
                        EndPos.z = EndPos.z - 2;
                        OneTimeVariableUpdate();
                    }
                    if (hit.collider.name == "LeftArrow")
                    {
                        EndPos.z = EndPos.z + 2;
                        OneTimeVariableUpdate();
                    }
                    if (hit.collider.name == "ForwardArrow")
                    {
                        EndPos.x = EndPos.x + 2;
                        OneTimeVariableUpdate();
                    }
                    if (hit.collider.name == "BackArrow")
                    {
                        EndPos.x = EndPos.x - 2;
                        OneTimeVariableUpdate();
                    }
                }
            }
        }
        if (StartPos != EndPos)
        {
            MoveObject();
        }
    }

    private void OneTimeVariableUpdate()
    {
        allowMovement = false;
        winCondition.actionRestante -= 1;
    }

    private void MoveObject()
    {
        time = time + Time.deltaTime;
        if (time > 1)
        {
            time = 1;
            allowMovement = true;
        }

        BlockToMove.transform.position = Vector3.Lerp(StartPos, EndPos, curve.Evaluate(time));
    }
}
