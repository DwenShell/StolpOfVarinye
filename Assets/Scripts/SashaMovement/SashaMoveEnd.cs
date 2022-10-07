using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SashaMoveEnd : MonoBehaviour
{
    private float MoveX;
    private float MoveZ;
    private float MoveY;
    public GameObject Character;
    public Transform[] FollowTarget;
    private int TargetNumber;
    public float moveSpeed;
    public float StairSpeed;
    private float Speed;
    private bool CanMove;
    public Animator CharaAnim;

    void Start()
    {
        TargetNumber = 0;
        CanMove = true;
        Speed = moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        MoveX = FollowTarget[TargetNumber].position.x - Character.transform.position.x;
        MoveY = FollowTarget[TargetNumber].position.y - Character.transform.position.y;
        MoveZ = FollowTarget[TargetNumber].position.z - Character.transform.position.z;
        Vector3 movementDirection = new Vector3(MoveX, MoveY, MoveZ);
        movementDirection.Normalize();
        if (CanMove == true)
        {
            //Fait se déplacer le personnage vers sa cible
            Character.transform.Translate(movementDirection * Speed * Time.deltaTime, Space.World);
        }

        if ((MoveX >= -0.05 && MoveZ >= -0.05) && (MoveX <= 0.05 && MoveZ <= 0.05) && CanMove == true)
        {
            if (TargetNumber == 1)
            {
                CanMove = false;
                CharaAnim.SetTrigger("Stop");
            }
            if (TargetNumber == 0)
            {
                TargetNumber = 1;
                Speed = StairSpeed;
            }

        }

    }
}

