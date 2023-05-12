using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class F2ndLevel : MonoBehaviour
{
    public GameObject fadePanel;

    GameObject player;
    bool isFalling = false;



    private void OnTriggerEnter(Collider other)
    {
        var sound = GetComponent<AudioSource>();
        sound.Play();

        fadePanel.SetActive(true);
        player = GameObject.Find("igrok");
        isFalling = true;
        Invoke("LoadNextScene", 2.5f);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("2ndLevel");
    }

    private void Update()
    {
        if (isFalling)
            player.transform.Translate(new Vector3(player.transform.position.x, player.transform.position.y + 15, player.transform.position.z));
    }
}
