using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTime : MonoBehaviour
{
    public int addTime = 5;
        
    private void OnMouseUp()
    {
        FindObjectOfType<CountDown>().currentTime += addTime;
    }
}
