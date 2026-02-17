using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public float timerVal = 0;
    public float timeMax = 60;
    public Slider timeslider;
    public float timespeed = 1;

    public TextMeshProUGUI limit;

 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        limit.text = timerVal.ToString();
        timeslider.maxValue = timeMax;
        timerVal = timeMax;

        timeslider.wholeNumbers = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timerVal <= 0)
        {
            Debug.Log("you lose");
            limit.text = "you lose";
        }
        else
        {
            timerVal -= (timespeed * Time.deltaTime);
            timeslider.value = timerVal;

            limit.text = timerVal.ToString();
        }
    }
}
