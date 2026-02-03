using UnityEngine;
using UnityEngine.UI;

public class coocoo : MonoBehaviour
{
    public Slider slider;
    public AudioSource clip;
    public Image bird;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value == 30 || slider.value == 60|| slider.value == 90)
        {
            clip.Play();
            bird.gameObject.SetActive(!gameObject.activeInHierarchy);
        }
    }
}
