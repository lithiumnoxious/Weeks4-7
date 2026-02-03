using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public Slider HealthBar;
    public SpriteRenderer player;
    public int life = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HealthBar.maxValue = life;
        HealthBar.value = life;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());


            if (player.bounds.Contains(mousePos) == true && Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            life -= 1;
            if (life <= 0)
            {
                gameObject.SetActive(false);
            }
        }

        HealthBar.value = life;
    }
    public void Heal()
    {
        life = (int)HealthBar.maxValue;
        gameObject.SetActive (true);
    }
}
