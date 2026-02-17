using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements.Experimental;

public class BoatMovement : MonoBehaviour
{
    public bool a,d = false;
    public float boatspeed;
    public float posX;
    public float wcreen;
    Vector2 bottomleft;
    Vector2 topRight;
    public SpriteRenderer sprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //getting sprite component so I can flip it when it goes left
        sprite = GetComponent<SpriteRenderer>();
        //getting screen borders
        bottomleft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        
        a = Keyboard.current.aKey.isPressed;
        d = Keyboard.current.dKey.isPressed;

        
        //movement
        if ((a) && (posX >= bottomleft.x))
        {
            Vector2 newPos = transform.position;
            newPos.x -= boatspeed * Time.deltaTime;
            transform.position = newPos;
            posX = newPos.x;
            //facingleft = true;
            sprite.flipX = true;
        }
        if ((d) && (posX <= topRight.x))
        {
            Vector2 newPos = transform.position;
            newPos.x += boatspeed * Time.deltaTime;
            transform.position = newPos;
            posX = newPos.x;
            //facingleft = false;
            sprite.flipX = false;
        }

    }
}
