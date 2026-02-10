using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class spawnbullet : MonoBehaviour
{
    public GameObject misslePrefab;
    public GameObject missle;
    public float t = 0;
    public SpriteRenderer misslesr;
    public List<GameObject> missles;
    public GameObject spawner;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 Spawn = spawner.transform.position;
       if (Mouse.current.rightButton.wasReleasedThisFrame)
        {
            missle = Instantiate(misslePrefab,Spawn,Quaternion.identity);
            misslesr = missle.GetComponent<SpriteRenderer>();
            missles.Add(missle);
            


        }


        if (Keyboard.current.spaceKey.wasReleasedThisFrame)
        {
            missles.RemoveAt(0);
            Destroy(missle);
        }

 

    }
}
