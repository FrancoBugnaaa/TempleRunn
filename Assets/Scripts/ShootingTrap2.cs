using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTrap2 : MonoBehaviour
{
    public GameObject bullet;
    float sec = 1f;
    float secDeltaTime;

    void Start()
    {
        StartCoroutine(Example());
    }
    void Update()
    {
        secDeltaTime -= Time.deltaTime;
        if (secDeltaTime <= 0)
        {
            Example();
            secDeltaTime += sec;
        }
    }

    IEnumerator Example()
    {
        
        GameObject BulletClone;
        BulletClone = Instantiate(bullet, transform.position, transform.rotation);
        yield return new WaitForSeconds(4);
        Destroy(BulletClone, 2);
    }
}

