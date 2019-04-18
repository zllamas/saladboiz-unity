using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    public class enterapt : MonoBehaviour
{

    public System.String gotoScene; // string of the scene to goto
    public int waitTime = 5;

    void OnMouseOver()
    {   
        if (Input.GetMouseButtonDown(0)){
            StartCoroutine(LoadYourAsyncScene());
        }
    }

    IEnumerator SetUpImage()
    {

        yield return new WaitForSeconds(waitTime);
    }

    IEnumerator LoadYourAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(gotoScene);
        // set loading image up

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
