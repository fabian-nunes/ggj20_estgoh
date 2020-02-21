using System;
using System.Collections;
using System.Collections.Generic;
using Kino;
using UnityEngine;

public class GG : MonoBehaviour
{

    public float currentTime = 10f;
    public GameObject waterTower;
    public GameObject waterTower2;
    private bool glitchG = false;
    public GameObject box;
    public GameObject part;
    public GameObject cam;

    private void OnTriggerEnter(Collider other)
    {
        if (glitchG == false)
        {
            cam.GetComponent<DigitalGlitch>().intensity = (float)0.1;
            waterTower.SetActive(false);
            waterTower2.SetActive(false);

            Invoke("dead", 2);
            glitchG = true;
            
            box.GetComponent<Renderer>().material.color = Color.red;
            part.SetActive(true);
        }
        


    }

    private void dead()
    {
        cam.GetComponent<DigitalGlitch>().intensity = 0;
    }
}
