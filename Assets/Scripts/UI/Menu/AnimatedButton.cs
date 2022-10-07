using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedButton : MonoBehaviour
{
    private Vector2 ActualPos;
    private int State =1 ;

    void Update()
    {
        ActualPos = this.transform.position;
        Debug.Log(ActualPos);
        Debug.Log(State);
        if (ActualPos.y <= 1585 && State == 1)
        { 
            this.transform.Translate(new Vector2(0, 10 * Time.deltaTime));
            if (ActualPos.y == 1584)
                State = 2;
        }
        if (ActualPos.y >= 1571 && State == 2)
        {
            this.transform.Translate(new Vector2(0, -10 * Time.deltaTime));
            if (ActualPos.y == 1571)
                State = 3;
        }
        /*if (ActualPos.x <= 380 && State == 3)
        {
            this.transform.Translate(new Vector2(0, 10 * Time.deltaTime));
            if (ActualPos.x == 380)
                State = 4;
        }
        if (ActualPos.x >= 360 && State == 4)
        {
            this.transform.Translate(new Vector2(0, -10 * Time.deltaTime));
            if (ActualPos.x == 360)
                State = 1;
        }*/
    }
}
