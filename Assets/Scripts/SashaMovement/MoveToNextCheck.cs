using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToNextCheck : MonoBehaviour
{
    public GameObject character;
    public GameObject nextCheck;
    public GameObject actualCheck;
    public bool lastDestination;
    public bool winDestination;

    [SerializeField] private IsItWin datas;
    [SerializeField] private AnimationCurve curve;

    private Vector3 TargetPosition;
    private Quaternion TargetRotation;
    private Vector3 StartPos;
    private Vector3 EndPos;
    private float time = 0;
    Quaternion PlayerRotation;
    private float rotationSpeed = 2;

    private void Start()
    {
        StartPos = character.transform.localPosition;
        EndPos = transform.localPosition;
    }

    private void Update()
    {
        /*PlayerRotation = Quaternion.LookRotation(actualCheck.transform.position - character.transform.position);
        Debug.Log(PlayerRotation);
        character.transform.rotation = Quaternion.RotateTowards(character.transform.rotation, PlayerRotation, rotationSpeed * Time.deltaTime);*/

        TargetPosition = actualCheck.transform.position;
        TargetRotation = actualCheck.transform.rotation;
        character.transform.rotation = Quaternion.Lerp(character.transform.rotation, TargetRotation, Time.deltaTime * rotationSpeed);

        time = time + Time.deltaTime/2;
        if (time < 1)
            character.transform.localPosition = Vector3.Lerp(StartPos, EndPos, curve.Evaluate(time));
        if (time > 1)
        {
            if (lastDestination == true)
            {
                if (winDestination == true)
                {
                    datas.characterAtGoodPlace = true;
                }
                actualCheck.SetActive(false);
            }
            if (lastDestination == false)
            {
                nextCheck.SetActive(true);
                actualCheck.SetActive(false);

            }
        }
    }
}
