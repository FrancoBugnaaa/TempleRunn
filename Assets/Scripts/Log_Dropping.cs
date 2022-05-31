using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log_Dropping : MonoBehaviour
{
    public Transform spawnear;
    public GameObject log;
    GameObject clone;

    void Start()
    {
        StartCoroutine(ExampleCoroutine());
    }


    IEnumerator ExampleCoroutine()
    {

        while (true)
        {
            clone = Instantiate(log, spawnear.transform.position, spawnear.transform.rotation);
            yield return new WaitForSeconds(3);
            Destroy(clone, 15);
        }


    }
}

//https://answers.unity.com/questions/1784952/add-delay-in-while-loop.html
