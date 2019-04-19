using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class goThroughScene : MonoBehaviour
{

    public string folder;
    public Image img;

    int numimg = 0;
    int curr = 1;

    // Start is called before the first frame update
    void Start()
    {
        string[] files = Directory.GetFiles(Application.dataPath + "/Resources/" +folder);
        foreach (string fi in files)
        {
            numimg++;
        }
        numimg /= 2;
    }

    IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background as the current Scene runs.
        // This is particularly good for creating loading screens.
        // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
        // a sceneBuildIndex of 1 as shown in Build Settings.

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("level_select");

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void iter()
    {
        if (curr < numimg)
        {
            curr++;
            string currstring = curr.ToString();
            Debug.Log(folder + "/" + currstring + ".png");
            Sprite sp = Resources.Load<Sprite>(folder + "/" + currstring);
            img.sprite = sp;
            if (curr == numimg)
            {
                // update button sprite
            }
        }
        else
        {
            StartCoroutine(LoadYourAsyncScene());
        }
        
    }
}
