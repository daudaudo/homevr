﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseController : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    string objectId;
    void Start()
    {
    }
    public void StartAni(){
        objectId = "isOpen_Obj_" + this.gameObject.GetComponent<MoveableObject>().objectNumber.ToString();
        bool isOpen = anim.GetBool(objectId);
		anim.enabled = true;
		anim.SetBool(objectId,!isOpen);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
