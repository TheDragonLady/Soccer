using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBlocks : MonoBehaviour
{
    public float xValue;
    public float yValue;
    public float zValue;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);   
    }
}
