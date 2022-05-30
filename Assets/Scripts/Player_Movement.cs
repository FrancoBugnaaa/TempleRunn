using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    float movementspeed = 0.1f;
    float rotationspeed = 3;
    float jumpForce = 3;
    int maxjumps = 20;


    int hasjump;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        hasjump = maxjumps;
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
        if (Input.GetKey(KeyCode.D) && hasjump == maxjumps)
        {
            transform.Rotate(0, rotationspeed, 0);
        }
        if (Input.GetKey(KeyCode.A) && hasjump == maxjumps)
        {
            transform.Translate(0, -rotationspeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space) && hasjump > 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasjump--;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "piso")
        {
            hasjump = maxjumps;
        }
        if (col.gameObject.name == "DeathWall")
        {
            transform.position = new Vector3(0.01f, 0.908f, -4.78f);
        }
        if (col.gameObject.name == "Ring")
        {
            transform.position = new Vector3(0.01f, 0.908f, -4.13f);
        }
    }
}
   
