using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class cannon : MonoBehaviour
{
    public float pointVal;
    public float rotospeed = 5;
    public Slider steer;
    public bool left, right = false;

    public BoatMovement boat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 newRot = transform.eulerAngles;
        newRot.z = pointVal;

        left = Keyboard.current.leftArrowKey.isPressed;
        right = Keyboard.current.rightArrowKey.isPressed;

        //simular to how the steeringwheel is calculated

        //rotating left
        if (left && pointVal > -40)
        {
            newRot.z -= rotospeed * Time.deltaTime;
            transform.eulerAngles = newRot;
        }

        //rotating right
        if (right && pointVal < 40)
        {
            newRot.z += rotospeed * Time.deltaTime;
            transform.eulerAngles = newRot;
        }
        pointVal = newRot.z;
    }
}
