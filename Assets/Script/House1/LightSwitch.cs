using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject Light;
    bool state;

    void Start()
    {
        state = false;
    }

    public void ClickLightSwitch()
    {
        if (state == false)
        {
            state = true;
            Light.SetActive(state);
        }
        else
        {
            state = false;
            Light.SetActive(state);
        }
    }
}
