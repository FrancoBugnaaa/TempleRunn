using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCounter : MonoBehaviour
{
    public static int countervida = 200;
    public Text vida;

    void Start()
    {
        
    }

    void Update()
    {
        if (countervida > 0)
        {
            vida.enabled = true;
            vida.text = ("vida:" + countervida.ToString() + "/200");
        }
        else
        {
            vida.enabled = false;
        }
    }
}
