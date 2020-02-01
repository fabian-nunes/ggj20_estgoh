using System;
using System.Collections;
using System.Collections.Generic;
using Kino;
using UnityEngine;

public class Pausemenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private bool isPaused;
    public GameObject camera;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            camera.GetComponent<CameraMovement>().enabled = false;
            ActivateMenu();
        }

        else
        {
            camera.GetComponent<CameraMovement>().enabled = true;
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        FindObjectOfType<DigitalGlitch>().intensity = 0;
        pauseMenuUI.SetActive(true);
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
        isPaused = false;
       
    }
}
