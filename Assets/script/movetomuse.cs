using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class ismouseover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Mouse.current.leftButton.wasPressedThisFrame == true && EventSystem.current.IsPointerOverGameObject() == false)
        {
            Vector2 Mousepos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            transform.position = Mousepos;
        }
    }
}
