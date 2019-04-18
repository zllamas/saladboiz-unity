using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    public class enterapt : MonoBehaviour
{
    
    void OnMouseOver()
    {   
        if (Input.GetMouseButtonDown(0)){
            SceneManager.LoadScene("loading_scene");
        }
    }
}
