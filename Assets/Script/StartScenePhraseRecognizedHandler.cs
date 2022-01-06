using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScenePhraseRecognizedHandler : MonoBehaviour
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
    public void handle(string command)
    {
        switch(command)
        {
            case "menu":
                Debug.Log(command);
                menu.SetActive(true);
                break;
            case "hide":
                Debug.Log(command);
                menu.SetActive(false);
                break;
            case "stop":
                Debug.Log(command);
                player.SetMoveState(false);
                isWalk = false;
                isDance = false;
                animator.SetBool(walk, isWalk);
                animator.SetBool(dance, isDance);
                break;
            case "move":
                Debug.Log(command);
                player.speed = 2f;
                player.SetMoveState(true);
                isWalk = true;
                isDance = false;
                animator.SetBool(dance, isDance);
                animator.SetBool(walk, isWalk);
                break;
            case "fast":
                Debug.Log(command);
                player.speed = 4f;
                break;
            case "slow":
                Debug.Log(command);
                player.speed = 2f;
                break;
            case "back":
                Debug.Log(command);
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
                Debug.Log(command);
                break;
        }
    }
}
