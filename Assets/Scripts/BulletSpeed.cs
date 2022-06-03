using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    float speed = 5f;

    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
