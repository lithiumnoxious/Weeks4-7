using UnityEngine;
using UnityEngine.Events;

public class contactsense : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool isinhazard = false;
    public UnityEvent enteredHazard;
    public UnityEvent exitHazard;

    public Transform shooter;

    public UnityEvent<float> rando;

    public GameObject arrowsPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //player in hazard
        if (hazard.bounds.Contains(transform.position))
        {
            if (isinhazard == true)
            {
                //still in the hazard
            }
            else
            {
                //first frame to have entered hazard
                isinhazard=true;
                Debug.Log("entered hazard");
                enteredHazard.Invoke();
            }
        }
        else
        {
            if (isinhazard == true)
            {
                //first fame out of the hazard
                isinhazard=false;
                Debug.Log("exited hazard");
                exitHazard.Invoke();
                rando.Invoke(Random.Range(2, 6));
            }
        }
        //yes or no
    }

    public void shownum(float number)
    {
        Debug.Log(number);
    }
    public void arrows()
    {
        Instantiate(arrowsPrefab,shooter.position,shooter.transform.rotation);
    }
}
