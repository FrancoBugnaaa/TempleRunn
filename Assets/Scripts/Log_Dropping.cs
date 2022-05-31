using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log_Dropping : MonoBehaviour
{
    public Transform spawner;
    public GameObject logs;
    GameObject clones;

    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }


    IEnumerator ExampleCoroutine()
    {

        while (true)
        {
            clones = Instantiate(logs, spawner.transform.position, spawner.transform.rotation);
            yield return new WaitForSeconds(5);
            Destroy(clones, 15);
        }


    }
}

//https://answers.unity.com/questions/1784952/add-delay-in-while-loop.html
