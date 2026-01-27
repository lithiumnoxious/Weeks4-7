using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class uiDemo : MonoBehaviour
{
    SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.aKey.wasReleasedThisFrame)
        {
            changecolor();
        }
    }

    public void changecolor()
    {
        sr.color = Random.ColorHSV();
    }
    public void SetScale()
    {
        transform.localScale = Vector3.one * 2;
    }
}
