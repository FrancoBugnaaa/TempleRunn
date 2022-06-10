using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text txtTime;
    int TotalTime = 60;
    float TimeLeft = 0;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (TotalTime - Mathf.Floor(Time.time) >= 0)
        {
            TimeLeft = TotalTime - Mathf.Floor(Time.time);
            txtTime.text = TimeLeft.ToString();
        }
    }
}
    

