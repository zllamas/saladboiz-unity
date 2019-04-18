using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class startSaladBoiz : MonoBehaviour
{
    //objects
    public GameObject about_info;
    public GameObject about_button;
    public Sprite about_icon; // set to sprite that shows '?'
    public Sprite about_x; // set to sprite that shows 'x'

    //FUNCTIONS
    public void ToggleAbout()
    {
        //toggle info section via button press
        about_info.SetActive(!about_info.activeSelf);

        //toggle about button display (open / close)
        if (about_info.activeSelf) // set icon to 'x' b/c info is showing
        {
            about_button.GetComponent<Image>().sprite = about_x;
        }
        else
        {
            about_button.GetComponent<Image>().sprite = about_icon;
        }
    }

    public void EnterCity()
    {
        SceneManager.LoadScene("city_scene");
    }

}