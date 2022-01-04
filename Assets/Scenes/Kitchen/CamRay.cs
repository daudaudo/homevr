using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamRay : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject child;
    GameObject parent;
    public LayerMask lm;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
        RaycastHit hit; 
        if(Physics.Raycast(ray,out hit, 30f, lm)){ 
            // Debug.Log(hit.collider.gameObject.name);
            child = hit.collider.gameObject;
            // Debug.Log(hit.transform.parent.parent.parent.gameObject.name);
            parent = hit.transform.parent.parent.parent.gameObject;
            if(child.GetComponent<MoveableObject>() != null){
                string animBoolNameNum = "isOpen_Obj_" + child.GetComponent<MoveableObject>().objectNumber.ToString();
                // Debug.Log(animBoolNameNum);
            }
        }
    }
}