using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpeed : MonoBehaviour
{
    float speed = 20f;

    void Update()
    {
        transform.Translate(speed * 0, 0, Time.deltaTime);
    }
}
