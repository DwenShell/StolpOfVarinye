using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObjectButton : MonoBehaviour
{
    public GameObject MoveObject;

    private float movement;
    public void MoveUP()
    {
        movement = 1;
    }
    public void MoveDown()
    {
        movement = 2;
    }
    public void MoveRight()
    {
        movement = 3;
    }
    public void MoveLeft()
    {
        movement = 4;
    }
    public void MoveForward()
    {
        movement = 5;
    }
    public void MoveBack()
    {
        movement = 6;
    }

    private void Update()
    {
        if (movement != 0)
            deplacement(movement);
    }

    private void deplacement(float a)
    {
        if (a == 1)
            MoveObject.transform.Translate(Vector3.up * 2 * Time.deltaTime);
        if (a == 2)
            MoveObject.transform.Translate(Vector3.down * 2 * Time.deltaTime);
        if (a == 3)
            MoveObject.transform.Translate(Vector3.right * 2 * Time.deltaTime);
        if (a == 4)
            MoveObject.transform.Translate(Vector3.left * 2 * Time.deltaTime);
        if (a == 5)
            MoveObject.transform.Translate(Vector3.forward * 2 * Time.deltaTime);
        if (a == 6)
            MoveObject.transform.Translate(Vector3.back * 2 * Time.deltaTime);
    }
}
