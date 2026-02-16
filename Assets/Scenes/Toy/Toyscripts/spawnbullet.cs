using System;
using System.Collections.Generic;
using UnityEngine;

public class bulletspawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject spawnedbullet;
    public cannon CannonScript;
    public GameObject spawner;
    public SpriteRenderer bulletsr;
    public List <GameObject> Bullets;


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
        Vector2 spawnPos = spawner.transform.position;
        //Vector3 newRot = transform.eulerAngles;
        //newRot.z = CannonScript.pointVal;

        spawnedbullet = Instantiate(bulletPrefab, spawnPos, Quaternion.identity);
        bulletsr = spawnedbullet.GetComponent<SpriteRenderer>();
        Bullets.Add( spawnedbullet );

    }

}
