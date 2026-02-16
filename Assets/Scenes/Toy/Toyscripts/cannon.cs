using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class cannon : MonoBehaviour
{
    public float pointVal;
    public float rotospeed = 10;
    public Slider steer;

    public BoatMovement boat;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //Vector2 direction = mousePos - (Vector2) transform.position;
        //transform.up = -direction;
        
        Vector3 newRot = transform.eulerAngles;
        newRot.z = pointVal;
        
        //rotating left
        if (pointVal >= steer.value)
        {
            newRot.z -= rotospeed * Time.deltaTime;
            transform.eulerAngles = newRot;
        }

        //rotating right
        if (pointVal <= steer.value - 63.5)
        {
            newRot.z += rotospeed * Time.deltaTime;
            transform.eulerAngles = newRot;
        }
        pointVal = newRot.z;
    }
}
