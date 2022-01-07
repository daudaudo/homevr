using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menu,menuNext,menuP;
    public Text view;
    public string house;
    AudioSource pop;
    private void Start()
    {
        pop = GameObject.Find("Pop").GetComponent<AudioSource>();
    }
    public void Click()
    {
        pop.Play();
        menu.SetActive(false);
        menuNext.SetActive(true);
    }
    public void Back(){
        pop.Play();
        menu.SetActive(false);
        menuP.SetActive(true);
    }
    public void selectHouse(){
        pop.Play();
        view.text = house;
    }
    public void LoadScene(){
        pop.Play();
        SceneManager.LoadScene(view.text);
    }
}
