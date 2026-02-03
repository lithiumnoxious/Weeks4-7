using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;
using Slider = UnityEngine.UI.Slider;

public class uiDemo : MonoBehaviour
{
    SpriteRenderer sr;
    public Image duckyImage;
    public int howManyclicks = 0;
    public TextMeshProUGUI score;
    public Slider slider;
    public TextMeshProUGUI sliderDis;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        score.text = howManyclicks.ToString();

        slider.wholeNumbers = true;
    }

    // Update is called once per frame
    void Update()
    {
        sliderDis.text = slider.value.ToString();
        if (Keyboard.current.aKey.wasReleasedThisFrame)
        {
            changecolor();
        }
    }

    public void changecolor()
    {
  
        sr.color = Random.ColorHSV();
        duckyImage.color = sr.color;
    }
    public void SetScale(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }

    public void AddtoClicks()
    {
        howManyclicks++;
        score.text = howManyclicks.ToString();
    }

}
