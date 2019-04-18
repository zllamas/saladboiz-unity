using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class beKindRewind : MonoBehaviour
{
    public GameObject restart_button;

    public void restartSaladBoiz()
    {
        SceneManager.LoadScene("opening_scene");
    }

}