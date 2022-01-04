using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class RemoteTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject TvCover;
    bool state;
    // Start is called before the first frame update
    void Start()
    {
        state = false;
    }
    
    public void UseRemote()
    {
        if (state == false)
        {
            Destroy(TvCover);
            videoPlayer.Play();
            state = true;
        }
        else
        {
            videoPlayer.Pause();
            state = false;
        }
    }
}
