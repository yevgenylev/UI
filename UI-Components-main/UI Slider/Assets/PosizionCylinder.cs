using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosizionCylinder : MonoBehaviour
{
    float up = 100f;
    void Update()
    {
        transform.position = new Vector3(550, up, 440);
    }
    public void Up(float newup)
    {
        up = newup;
    }
}
