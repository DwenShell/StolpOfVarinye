using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoupeSize : MonoBehaviour
{
    public GameObject loupe;
    public float Size;

    private void Update()
    {
        loupe.transform.localScale = new Vector3(Size, Size, Size);
    }
}
