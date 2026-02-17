using System.Collections.Generic;
using UnityEngine;

public class bulletspawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject bulletPrefab;
    public GameObject spawnedbullet;
    public SpriteRenderer bulletsr;
    public List <GameObject> Bullets;

    public float time = 0;
    public Transform spawnP;
    public GameObject AlienPrefab;
    public GameObject SpawnedAlien;
    public SpriteRenderer aliensr;
    public List<GameObject> aliens;
  


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time > 2)
        {
            
            SpawnedAlien = Instantiate(AlienPrefab, new Vector2(Random.Range(-20f, 20f), Random.Range(-18f, -16f)), Quaternion.identity);
            aliensr = GetComponent<SpriteRenderer>();
            aliens.Add(SpawnedAlien);
            time = 0;
        }
        else
        {
            time += 1 *Time.deltaTime;
        }
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
