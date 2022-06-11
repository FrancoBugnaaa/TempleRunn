using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text txtTimeFloored;
    public Text Over;
    public GameObject Retry2;

    // Start is called before the first frame update
    void Start()
    {
        Over.enabled = false;
        Retry2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float elapsedTime = Time.time;
        txtTimeFloored.text = Mathf.Floor(elapsedTime).ToString();
       if(LifeCounter.countervida == 0)
        {
            txtTimeFloored.gameObject.SetActive(false); 
        }
    }
}
    

