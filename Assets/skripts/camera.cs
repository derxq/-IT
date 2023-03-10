using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float mouseSensitiviti = 300f;

    public Transform Character;

    private float xRotation = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float mouseX = Input.GetAxis("MouseX") * mouseSensitiviti * Time.deltaTime;
        float mouseY = Input.GetAxis("MouseY") * mouseSensitiviti * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Character.Rotate(Vector3.up * mouseX);
    }
}

