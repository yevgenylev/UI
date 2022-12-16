using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textswap : MonoBehaviour
{
    [SerializeField] RectTransform txtRT;
    [SerializeField] RectTransform contentRT;
    void Update()
    {
        var size = contentRT.sizeDelta;
        size.y = txtRT.sizeDelta.y;
        contentRT.sizeDelta = size;
    }
}
