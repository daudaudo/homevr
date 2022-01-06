using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows.Speech;

public class StartScenePhraseRecognizedHandler : MonoBehaviour, PhraseRecognizedHandler
{
    public GameObject menu;
    PlayerMovement player;
    public Animator animator;
    string walk = "walk";
    string dance = "dance";
    bool isWalk = false;
    bool isDance = false;
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
                isWalk = false;
                isDance = false;
                animator.SetBool(walk, isWalk);
                animator.SetBool(dance, isDance);
                break;
            case "move":
                Debug.Log(args.text);
                player.speed = 2f;
                player.SetMoveState(true);
                isWalk = true;
                isDance = false;
                animator.SetBool(dance, isDance);
                animator.SetBool(walk, isWalk);
                break;
            case "fast":
                Debug.Log(args.text);
                player.speed = 4f;
                break;
            case "slow":
                Debug.Log(args.text);
                player.speed = 2f;
                break;
            case "back":
                Debug.Log(args.text);
                player.speed = -2f;
                player.SetMoveState(true);
                break;
            case "dance":
                isDance = true;
                isWalk = false;
                animator.SetBool(walk, isWalk);
                animator.SetBool(dance, isDance);
                break;
            case "exit":
                SceneManager.LoadScene("MainScene");
                break;
            default :
                Debug.Log(args.text);
                break;
        }
    }
}
