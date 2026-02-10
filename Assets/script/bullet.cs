using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class bullet : MonoBehaviour
{
    public float speed = 10;
    public point point;
    public float mouseX;
    public float mouseY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 newpos = transform.position;
        //newpos.x += newpos.x * speed * Time.deltaTime;
        //newpos.y = newpos.y * speed * Time.deltaTime;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 direction = mousePos - (Vector2)transform.position;
        transform.up = direction;
        transform.position += transform.up * speed *Time.deltaTime;
        mouseX = mousePos.x;
        mouseY = mousePos.y;
    }
}
