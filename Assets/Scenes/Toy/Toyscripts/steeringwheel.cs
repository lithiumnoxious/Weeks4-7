using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class steeringwheel : MonoBehaviour
{
    public bool left = false;
    public bool right = false;

    public float steerVal = 5;
    public float steerValMax = 10;
    public float steerSpeed = 1;
    public Slider steer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        steer = GetComponent<Slider>();
        
        steer.maxValue = steerValMax;

    }

    // Update is called once per frame
    void Update()
    {
        left = Keyboard.current.leftArrowKey.isPressed;
        right = Keyboard.current.rightArrowKey.isPressed;

        if (left && steerVal > 2.5)
        {
            steerVal -= 0.1f;
            steer.value = steerVal;
        }
        if (right && steerVal < 7.5)
        {
            steerVal += 0.1f;
            steer.value = steerVal;
        }
        


        //steerVal += (steerSpeed * Time.deltaTime);
        //if (steerVal > steerValMax)
        //{
        //    steerVal = 0;
        //}
        steer.value = steerVal;

    }
}
