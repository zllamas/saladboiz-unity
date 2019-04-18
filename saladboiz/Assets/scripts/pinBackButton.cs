using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinBackButton : MonoBehaviour
{

    public GameObject aptPin;
    public Camera aptCam;
    public Camera mainCam;
    // for every new pin add as public and set it the same way as is done here

    public void cameraReturn()
    {
        aptCam.enabled = false;
        mainCam.enabled = true;        
        aptPin.SetActive(true);
        gameObject.SetActive(false);
    }

}
