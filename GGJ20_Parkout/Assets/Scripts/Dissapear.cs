using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dissapear : MonoBehaviour
{
    private float currentTime = 0f;
    public float startingTime = 10f;
    public GameObject dObject;
   
    bool test = false;
    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        if (test == false)
        {
            if (currentTime <= 0)
            {
                currentTime = 0;
                dObject.SetActive(false);
                test = true;
            }
        }
        
    }
    
}
