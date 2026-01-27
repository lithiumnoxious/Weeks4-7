using UnityEngine;
using UnityEngine.InputSystem;

public class spawner : MonoBehaviour
{
    public GameObject bombPrefab;
    public GameObject droppedBomb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy (droppedBomb,10*Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            //Vector2 spawnPos = Vector2.zero;
            droppedBomb = Instantiate (bombPrefab,Vector2.zero, Quaternion.identity);

        }
    }
}
