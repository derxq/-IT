using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class F2ndLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // ��������� ���� �����
        AudioClip hitSound;
    }

    void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.name == "Ground")
        {

            gameObject.audio.clip = hitSound;
        }
            // ��������� ���� ���������� �����



            SceneManager.LoadScene("2ndLevel");
    }
}
