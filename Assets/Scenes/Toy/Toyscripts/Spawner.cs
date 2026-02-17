using System.Collections.Generic;
using UnityEngine;

public class bulletspawner : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject bulletPrefab;
    public GameObject spawnedbullet;
    public SpriteRenderer bulletsr;
    public List <GameObject> bullets = new List<GameObject>();


    public float time = 0;
    public Transform spawnP;
    public GameObject AlienPrefab;
    public GameObject SpawnedAlien;
    public SpriteRenderer aliensr;
    public List<GameObject> aliens = new List<GameObject>();

    public float dist = 2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //every 2 seconds the alien spawns
        if (time > 2)
        {

            SpawnedAlien = Instantiate(AlienPrefab, new Vector2(Random.Range(-20f, 20f), Random.Range(-18f, -16f)), Quaternion.identity);
            aliensr = GetComponent<SpriteRenderer>();
            aliens.Add(SpawnedAlien);
            time = 0;
        }
        else
        {
            time += 1 * Time.deltaTime;
        }

        //when a bullet gets close to an alien they are both removed from the arraylist
        //they are also destroyed
        for (int i = bullets.Count - 1; i >= 0; i--)
        {
            GameObject bullet = bullets[i];

            if (bullet != null)
            {
                for (int j = aliens.Count - 1; j >= 0; j--)
                {
                    GameObject alien = aliens[j];

                    if (alien != null)
                    {
                        float distance = Vector3.Distance(
                            alien.transform.position,
                            bullet.transform.position
                        );

                        if (distance <= dist)
                        {
                            Destroy(bullet);
                            Destroy(alien);

                            bullets.RemoveAt(i);
                            aliens.RemoveAt(j);
                        }
                    }
                }
            }
        }
    }

    public void SpawnBullet()
    {
        //I had tried various different ways to make this code work
        //basically I wanted the spawned bullet prefab to be rotated in the same direction as when it was fired

        //spawnedbullet = Instantiate(bulletPrefab, spawnPos, Quaternion.identity);
        spawnedbullet = Instantiate(bulletPrefab, spawnPos.position, spawnPos.transform.rotation);
        bulletsr = spawnedbullet.GetComponent<SpriteRenderer>();
        bullets.Add( spawnedbullet );

    }

}
