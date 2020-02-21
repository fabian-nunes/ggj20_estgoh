using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public void OnTriggerEnter(Collider aWin)
    {
        SceneManager.LoadScene(0);
    }
}
