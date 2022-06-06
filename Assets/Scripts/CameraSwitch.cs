using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{

    public GameObject CameraOne;
    public GameObject CameraTwo;

    AudioListener CameraOneAudioLis;
    AudioListener CameraTwoAudioLis;

    // Start is called before the first frame update
    void Start()
    {
        CameraOneAudioLis = CameraOne.GetComponent<AudioListener>();
        CameraTwoAudioLis = CameraTwo.GetComponent<AudioListener>();

    }

    // Update is called once per frame
    void Update()
    {
        switchCamera();
    }


    void switchCamera() {
        if (Input.GetKey(KeyCode.C))
        {
            cameraChangeCounter();
        }
    }

    void cameraChangeCounter()
    {
        int cameraPositionCounter = PlayerPrefs.GetInt("CameraPosition");
        cameraPositionCounter++;
        cameraPositionChange(cameraPositionCounter);
    }

    void cameraPositionChange(int camPosition)
    {
        if (camPosition > 1)
        {
            camPosition = 0;
        }

        PlayerPrefs.SetInt("CameraPosition", camPosition);

        if (camPosition == 0)
        {
            CameraOne.SetActive(true);
            CameraOneAudioLis.enabled = true;

            CameraTwoAudioLis.enabled = false;
            CameraTwo.SetActive(false);
        }

        if (camPosition == 1)
        {
            CameraTwo.SetActive(true);
            CameraTwoAudioLis.enabled = true;

            CameraOneAudioLis.enabled = false;
            CameraOne.SetActive(false);
        }
    }
}
