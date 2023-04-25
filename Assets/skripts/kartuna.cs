using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kartuna : MonoBehaviour
{

    bool картина_повернута = false;


    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!картина_повернута)
                    transform.Rotate(0, 0, 18);
            }
        }
    }


}
