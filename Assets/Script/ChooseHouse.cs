using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseHouse : MonoBehaviour
{
    //public Transform house;
    Vector3 oldPos, oldRotation, oldScale;
    bool isRotate, isSelect;
    public bool type1;
    public string sceneName;
    public GameObject light,menu;
    AudioSource pop;

    private void Start()
    {
        pop = GameObject.Find("Pop").GetComponent<AudioSource>();
        isRotate = false;
        oldPos = transform.position;
        oldRotation = transform.eulerAngles;
        oldScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if(isRotate)
        {
            transform.Rotate(new Vector3(0, 20, 0) * Time.deltaTime);
        }
    }

    public void Enter()
    {
        pop.Play();
        light.SetActive(true);
        menu.SetActive(true);
        isRotate = true;
        if(type1)
        {
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
        else
        {
            transform.localScale = new Vector3(0.6f, 0.6f, 0.25f);
        }
    }

    public void Exit()
    {
        light.SetActive(false);
        menu.SetActive(false);
        isRotate = false;
        transform.eulerAngles = oldRotation;
        transform.localScale = oldScale;
    }

    public void Click()
    {
        if(sceneName != "")
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
