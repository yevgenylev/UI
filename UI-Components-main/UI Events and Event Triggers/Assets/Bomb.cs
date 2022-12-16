using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bomb : MonoBehaviour
{
    // Start is called before the first frame update
    public void TurnRed()
    {
        GetComponent<Image>().color = Color.red;
    }

}
