using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class time : MonoBehaviour
{
    public float timerVal = 0;
    public float timeMax = 60;
    public Slider timeslider;
    public float timespeed = 1;
 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //timeslider.maxValue = timeMax;

    }

    // Update is called once per frame
    void Update()
    {
        //timerVal += (timespeed * Time.deltaTime);
        //if(timerVal > timeMax)
        //{
        //    timerVal = 0;
        //}
        //timeslider.value = timerVal;
    }
}
