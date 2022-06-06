using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    float movementspeed = 0.05f;
    float jumpForce = 7;
    int maxjumps = 1;
    public GameObject Boost;
    public GameObject Boost2;
    bool hasJump = true;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, movementspeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(movementspeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movementspeed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (hasJump)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                hasJump = false;
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "piso")
        {
            hasJump = true;
        }
        if (col.gameObject.name == "DeathWall")
        {
            transform.position = new Vector3(0.01f, 0.908f, -4.51f);
        }
        if (col.gameObject.name == "Restart")
        {
            transform.position = new Vector3(0.01f, 0.908f, -4.51f);
            movementspeed += 0.05f;
        }
        if (col.gameObject.name == "Restart2")
        {
            transform.position = new Vector3(0.01f, 0.908f, -4.51f);
        }
        if (col.gameObject.name == "Log(Clone)")
        {
            transform.position = new Vector3(0.01f, 0.908f, -4.51f);
        }
        if(col.gameObject.name == "Bullet(Clone)")
        {
            transform.position = new Vector3(0.01f, 0.908f, -4.51f);
        }
       
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Boost")
        {
            jumpForce = jumpForce + 2;
            Destroy(Boost);
        }
        if (col.gameObject.name == "Boost2")
        {
            jumpForce = jumpForce - 4;
            Destroy(Boost2);
        }
    }
}
   
