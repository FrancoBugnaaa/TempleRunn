using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text txtTime;
    public static int TotalTime = 60;
    public static float TimeLeft = 0;
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
        if (TotalTime - Mathf.Floor(Time.time) >= 0)
        {
            TimeLeft = TotalTime - Mathf.Floor(Time.time);
            txtTime.text = TimeLeft.ToString();
        }
       if(TimeLeft == 0)
        {
            Over.enabled = true;
            Retry2.gameObject.SetActive(true);
        }
       if(LifeCounter.countervida == 0)
        {
            txtTime.gameObject.SetActive(false); 
        }
    }
}
    

