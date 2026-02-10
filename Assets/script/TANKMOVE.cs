using UnityEngine;
using UnityEngine.InputSystem;

public class TANKMOVE : MonoBehaviour
{
    public bool left = false;
    public bool right = false;
    public float tankspeed;
    public float posX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        left = Keyboard.current.leftArrowKey.isPressed;
        right = Keyboard.current.rightArrowKey.isPressed;

        if (left)
        {
            Vector2 newPos = transform.position;
            newPos.x -= tankspeed * Time.deltaTime;
            transform.position = newPos;
            posX = newPos.x;
        }
        if (right)
        {
            Vector2 newPos = transform.position;
            newPos.x += tankspeed * Time.deltaTime;
            transform.position = newPos;
            posX = newPos.x;
        }
    }
}
