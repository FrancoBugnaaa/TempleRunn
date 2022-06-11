using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Movement : MonoBehaviour
{
    float movementspeed = 0.07f;
    float jumpForce = 7;
    int maxjumps = 1;
    public GameObject Boost;
    public GameObject Boost2;
    bool hasJump = true;
    Rigidbody rb;

    public Text gameOver;
    public Text YouWon;
    public GameObject Retry;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        YouWon.enabled = false;
        gameOver.enabled = false;
        Retry.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 1)
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
        if (LifeCounter.countervida <= 0)
        {
            transform.position = new Vector3(0.01f, 0.908f, -4.51f);
            gameOver.enabled = true;
            Retry.gameObject.SetActive(true);
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
            LifeCounter.countervida -= 100;
        }
        if (col.gameObject.name == "Restart")
        {
            YouWon.enabled = true;
            Retry.gameObject.SetActive(true);
            Time.timeScale = 0;
            //transform.position = new Vector3(0.01f, 0.908f, -4.51f);
        }
        if (col.gameObject.name == "Restart2")
        {
            transform.position = new Vector3(0.01f, 0.908f, -4.51f);
        }
        if (col.gameObject.name == "Log(Clone)")
        {
            transform.position = new Vector3(0.01f, 0.908f, -4.51f);
            LifeCounter.countervida -= 50;
        }
        if(col.gameObject.name == "Bullet(Clone)")
        {
            transform.position = new Vector3(0.01f, 0.908f, -4.51f);
            LifeCounter.countervida -= 20;
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
   
