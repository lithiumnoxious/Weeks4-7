using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public float timerValue = 0;
    public float timerMAX = 10;
    public Slider timerVis;
    public float speed = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerVis.maxValue = timerMAX;
    }

    // Update is called once per frame
    void Update()
    {
        timerValue += (speed*Time.deltaTime);
        if (timerValue > timerMAX)
        {
            timerValue = 0;
        }
        timerVis.value = timerValue;
    }
}
