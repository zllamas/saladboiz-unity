using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class playLoadVids : MonoBehaviour
{

    public VideoClip door; // the video leading into apartment
    public VideoClip loading; // personality card loading
    VideoPlayer player;

    void Start()
    {
        player = gameObject.GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.clip == door)
        {
            if (player.frame >= (long) player.frameCount)
            {
                player.Stop();
                player.clip = loading;
                player.Play();
            }
        }
    }
}
