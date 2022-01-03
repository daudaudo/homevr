using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenBench : MonoBehaviour
{
    Transform cabinet;
    int cabinetStatus, speed = 2;
    float oldPos;
    private void Start()
    {
        cabinet = GetComponent<Transform>();
        oldPos = cabinet.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        if (cabinetStatus == 1)
        {
            OpenCabinet();
        }
        else if (cabinetStatus == 2)
        {
            CloseCabinet();
        }
    }


    public void CabinetControl()
    {
        if (cabinet.position.z <= -6.5)
        {
            cabinetStatus = 1;
        }
        else
        {
            cabinetStatus = 2;
        }
    }

    public void OpenCabinet()
    {
        if (cabinet.position.z < -6.5)
        {
            cabinet.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else
        {
            cabinetStatus = 0;
        }

    }

    public void CloseCabinet()
    {
        if (cabinet.position.z > oldPos)
        {
            cabinet.Translate(Vector3.back * speed * Time.deltaTime);
        }
        else
        {
            cabinetStatus = 0;
        }
    }
}
