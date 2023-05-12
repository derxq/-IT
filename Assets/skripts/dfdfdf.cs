using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dfdfdf : MonoBehaviour
{
    public GameObject LoadingText;

    public void changeScene(int scene)
    {
        LoadingText.SetActive(true);
        SceneManager.LoadScene(scene);   
    }
}
