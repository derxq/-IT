using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
public void ButtonPlay()
    {
        SceneManager.LoadScene(1);
    }


    public void ButtonEXIT()
    {
        Application.Quit();
    }

    public void ButtonMENU()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
