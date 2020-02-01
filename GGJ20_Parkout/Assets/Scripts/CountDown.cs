using System.Collections;
using System.Collections.Generic;
using Kino;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 10f;
    public GameObject glitch;
    
    [SerializeField] private Text countDown;
    
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countDown.text = currentTime.ToString("0");

        if (currentTime <= startingTime * 0.25)
        {
            countDown.color = Color.red;
            glitch.GetComponent<DigitalGlitch>().intensity = (float) 0.05;
        }
        
        if (currentTime <= 0)
        {
            currentTime = 0;
            FindObjectOfType<GManager>().EndGame();
        }
    }
}
