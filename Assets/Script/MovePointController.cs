using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePointController : MonoBehaviour
{
    public GameObject movePoint;
   // public GameObject door;
    public Animator myDoor = null;
    public bool openTrigger = false;
    public bool closeTrigger = false;
    bool isOpen;

    private void Start()
    {
        isOpen = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (openTrigger && !isOpen)
        {
            myDoor.Play("OpenDoor", 0, 0f);
            isOpen = true; 
        }
        else if(closeTrigger && isOpen)
        {
            myDoor.Play("CloseDoor", 0, 0f);
            isOpen = false;
        }
    }

    public void Enter()
    {
        movePoint.GetComponent<Renderer>().material.color = new Color(1, 0, 0, 0.85f);

    }
    public void Exit()
    {
        movePoint.GetComponent<Renderer>().material.color = new Color(1, 0, 0, 0.2f);
    }

    public void Move()
    {
        GameObject player = GameObject.Find("Player");
        player.transform.position = transform.position;
    }
}
