using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class steeringwheel : MonoBehaviour
{
    public bool left = false;
    public bool right = false;

    public float steerVal = 25;
    public float steerValMax = 50;
    public float steerSpeed = 2f;
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

        if (left && steerVal > 10)
        {
            steerVal -= steerSpeed * Time.deltaTime;
            steer.value = steerVal;
        }
        if (right && steerVal < 40)
        {
            steerVal += steerSpeed * Time.deltaTime;
            steer.value = steerVal;
        }

        steer.value = steerVal;

    }
}
