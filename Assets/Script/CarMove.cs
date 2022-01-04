using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    string objectId;
    void Start()
    {
    }
    public void StartAni(){
        objectId = "isMove_Car_" + this.gameObject.GetComponent<MoveableObject>().objectNumber.ToString();
        bool isOpen = anim.GetBool(objectId);
		anim.enabled = true;
		anim.SetBool(objectId,!isOpen);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
