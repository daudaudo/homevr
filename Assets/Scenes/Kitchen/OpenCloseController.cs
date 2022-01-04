using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseController : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void StartAni(string number){
        bool isOpen = anim.GetBool(number);
        if (Input.GetKeyUp(KeyCode.Mouse0))
			{
				anim.enabled = true;
				anim.SetBool(number,!isOpen);
			}
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
