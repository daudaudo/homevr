using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanSwitch : MonoBehaviour
{
    bool isOn;
    public GameObject fan;
    private void Start()
    {
        isOn = false;
    }

    private void Update()
    {
        if(isOn)
        {
            fan.transform.Rotate(new Vector3(0, -20, 0));
        }
    }

    public void ClickFanSwitch()
    {
        if(isOn)
        {
            isOn = false;
        }
        else
        {
            isOn = true;
        }
    }
}
