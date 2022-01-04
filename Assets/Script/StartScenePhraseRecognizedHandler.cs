using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class StartScenePhraseRecognizedHandler : MonoBehaviour, PhraseRecognizedHandler
{
    public GameObject menu;
    PlayerMovement player;
    void Start(){
        player = FindObjectOfType<PlayerMovement>();
    }
    public void handle(PhraseRecognizedEventArgs args)
    {
        switch(args.text)
        {
            case "menu":
                Debug.Log(args.text);
                menu.SetActive(true);
                break;
            case "hide":
                Debug.Log(args.text);
                menu.SetActive(false);
                break;
            case "stop":
                Debug.Log(args.text);
                player.SetMoveState(false);
                break;
            case "move":
                Debug.Log(args.text);
                player.SetMoveState(true);
                break;
            case "fast":
                Debug.Log(args.text);
                player.speed = 4f;
                break;
            case "slow":
                Debug.Log(args.text);
                player.speed = 2f;
                break;
            default :
                Debug.Log(args.text);
                break;
            
        }
    }
}
