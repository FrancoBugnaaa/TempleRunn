using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{ 
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("GameScene");
            LifeCounter.countervida = 0;
            LifeCounter.countervida += 200;
            Timer.TotalTime = 0;
            Timer.TotalTime += 60;
            Timer.TimeLeft = 0;
            Timer.TimeLeft += 60;
        }
    }

}
