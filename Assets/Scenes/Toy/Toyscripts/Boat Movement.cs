using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements.Experimental;

public class BoatMovement : MonoBehaviour
{
    public bool left = false;
    public bool right = false;
    public bool a,d = false;
    public float boatspeed;
    public float posX;
    //public bool facingleft = false;
    public SpriteRenderer sprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //getting sprite component so I can flip it when it goes left
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //multiple ways for the ship to move
        left = Keyboard.current.leftArrowKey.isPressed;
        a = Keyboard.current.aKey.isPressed;
        right = Keyboard.current.rightArrowKey.isPressed;
        d = Keyboard.current.dKey.isPressed;

        if (left || a)
        {
            Vector2 newPos = transform.position;
            newPos.x -= boatspeed * Time.deltaTime;
            transform.position = newPos;
            posX = newPos.x;
            //facingleft = true;
            sprite.flipX = true;
        }
        if (right || d)
        {
            Vector2 newPos = transform.position;
            newPos.x += boatspeed * Time.deltaTime;
            transform.position = newPos;
            posX = newPos.x;
            //facingleft = false;
            sprite.flipX = false;
        }


        //extra code meant to check which direction the ship was facing
        //if (facingleft)
        //{
        //    sprite.flipX = true;
        //}
        //if (!facingleft)
        //{
        //    sprite.flipX = false;
        //}
    }
}
