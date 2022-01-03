using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageDoor : MonoBehaviour
{
    Transform door;
    int doorStatus, speed = 2;
    private void Start()
    {
        door = GetComponent<Transform>();
    }

    private void Update()
    {
        if(doorStatus == 1)
        {
            OpenGarageDoor();
        }
        else if(doorStatus == 2)
        {
            CloseGarageDoor();
        }
    }

    public void GarageDoorControl()
    {
        if(door.position.y <= 0)
        {
            doorStatus = 1;
        }
        else
        {
            doorStatus = 2;
        }
    }

    public void OpenGarageDoor()
    {
        if(door.position.y < 4)
        {
            door.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else
        {
            doorStatus = 0;
        }
        
    }

    public void CloseGarageDoor()
    {
        if (door.position.y > 0)
        {
            door.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else
        {
            doorStatus = 0;
        }
    }
}
