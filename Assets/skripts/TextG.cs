using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextG : MonoBehaviour
{
    public Text TextGameObject;
    public GameObject fadeOut;

    private string text;

    private void Start()
    {
        text = TextGameObject.text;
        TextGameObject.text = "";
        StartCoroutine(TextCoroutine());
    }
    IEnumerator TextCoroutine()
    {
     foreach(char abc in text)
        {
            TextGameObject.text += abc;
            yield return new WaitForSeconds(0.05f)
           ;
        }


        fadeOut.SetActive(true);          
     
     }
    











}