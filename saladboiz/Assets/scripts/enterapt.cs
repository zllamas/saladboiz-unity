using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    public class enterapt : MonoBehaviour
{

    public System.String gotoScene;

    void OnMouseOver()
    {   
        if (Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene(gotoScene);
        }
    }
}
