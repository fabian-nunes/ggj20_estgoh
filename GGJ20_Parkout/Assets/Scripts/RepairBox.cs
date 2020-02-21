using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepairBox : MonoBehaviour
{
    public GameObject wt;
    public GameObject key;
    public GameObject img;
    public GameObject box;
    public GameObject part;

    private void OnMouseDown()
    {
        if (key.GetComponent<key>().gotKey == true)
        {
            wt.SetActive(true);
            img.SetActive(false);
            box.GetComponent<Renderer>().material.color = Color.green;
            part.SetActive(false);
        }
    }
}
