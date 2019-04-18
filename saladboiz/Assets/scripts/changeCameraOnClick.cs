using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeCameraOnClick : MonoBehaviour
{
    Camera mainCam;
    public Camera gotoCam;
    public Button backbtn;

    void Start()
    {
        mainCam = Camera.main;
        mainCam.enabled = true;
        gotoCam.enabled = false;
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mainCam.enabled = false;
            gotoCam.enabled = true;
            gameObject.SetActive(false);
            backbtn.gameObject.SetActive(true);
        }
    }
}
