using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCube : MonoBehaviour
{
    public float speed = 25f;
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
    public void Speed(float newspeed)
    {
        speed = newspeed;
    }
}
