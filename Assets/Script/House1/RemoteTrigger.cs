using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class RemoteTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject TvCover;
    public AudioSource audio;
    bool state, isSpeak;
    // Start is called before the first frame update
    void Start()
    {
        state = false;
        isSpeak = false;
    }
    
    public void UseRemote()
    {
        isSpeak = true;
        if (state == false)
        {
            if (!isSpeak) {
                audio.Play();
            }      
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
