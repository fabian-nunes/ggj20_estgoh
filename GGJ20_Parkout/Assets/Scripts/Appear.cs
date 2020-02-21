using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    public GameObject dObject;
    public GameObject sObject;
    public int addTime = 5;
    

    void OnMouseDown()
    {
        dObject.SetActive(true);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        dObject.SetActive(true);
        sObject.SetActive(false);
        FindObjectOfType<CountDown>().currentTime += addTime;
    }
}
