﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {    
        Cursor.visible = true;
        AudioListener.pause = false;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
