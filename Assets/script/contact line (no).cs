using UnityEngine;
using UnityEngine.Events;

public class contactline : MonoBehaviour
{
    public Transform player;
    public SpriteRenderer playersr;
    public SpriteRenderer hazard;
    public bool isplayertrapped;
    public UnityEvent trapped;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hazard.bounds.Contains(player.transform.position))
        {
            if (isplayertrapped)
            {
                //somthing happpens
            }
            else
            {
                isplayertrapped = true;
                Debug.Log("entered hazard");
            }
        }
        else
        {
            if (isplayertrapped) 
            {
                isplayertrapped = false;
                Debug.Log("exited hazard");
            }
        }
    }
}
