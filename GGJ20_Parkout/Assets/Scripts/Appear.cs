using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    public GameObject dObject;
    public GameObject sObject;
    public int addTime = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
