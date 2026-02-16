using System;
using System.Collections.Generic;
using UnityEngine;

public class bulletspawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject spawnedbullet;

    public SpriteRenderer bulletsr;
    public List <GameObject> Bullets;
    public Transform spawnPos;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnBullet()
    {
        //I had tried various different ways to make this code work
        //basically I wanted the spawned bullet prefab to be rotated in the same direction as when it was fired

        //spawnedbullet = Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

        spawnedbullet = Instantiate(bulletPrefab, spawnPos.position, spawnPos.transform.rotation);

        bulletsr = spawnedbullet.GetComponent<SpriteRenderer>();
        Bullets.Add( spawnedbullet );

    }

}
