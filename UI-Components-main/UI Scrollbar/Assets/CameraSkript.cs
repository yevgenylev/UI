using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSkript : MonoBehaviour
{
    public float up = 1f;
    void Update()
    {
        transform.position = new Vector3(up + 330, 323,- 208);
    }
    public void Up(float newup)
    {
        if (newup != 0)
        {
            up = newup * 1500;
        }
    }
}
