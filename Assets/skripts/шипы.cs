using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class шипы : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        SceneManager.LoadScene("DefeatMenu");
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
     }
}
