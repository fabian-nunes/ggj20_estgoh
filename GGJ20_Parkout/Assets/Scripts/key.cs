using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class key : MonoBehaviour
{
    public bool gotKey = false;
    public GameObject keyS;
    public GameObject Up;
    public int time;
    private bool test = false;
    
    private void OnTriggerEnter(Collider other)
    {
        gotKey = true;
        keyS.SetActive(false);
        
        if (test == false)
        {
            FindObjectOfType<CountDown>().currentTime += time;
            test = true;
            Up.SetActive(true);
        }
       
    }
    
}
