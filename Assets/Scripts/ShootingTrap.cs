using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTrap : MonoBehaviour
{
    public GameObject bullet;
    float sec = 1f;
    float secDeltaTime;

    void Update()
    {
        secDeltaTime -= Time.deltaTime;
        if (secDeltaTime <= 0)
        {
            startPointFire();
            secDeltaTime += sec;
        }
    }

    public void startPointFire()
    {
        GameObject BulletClone;
        BulletClone = Instantiate(bullet, transform.position, transform.rotation);
        Destroy(BulletClone, 3);
    }
}

