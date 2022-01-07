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
    public void Click()
    {
        menu.SetActive(false);
        menuNext.SetActive(true);
    }
    public void Back(){
        menu.SetActive(false);
        menuP.SetActive(true);
    }
    public void selectHouse(){
        view.text = house;
    }
    public void LoadScene(){
        
        SceneManager.LoadScene(view.text);
    }
}
