using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawnScript : MonoBehaviour
{
    public GameObject powerup;
    public float timer = 0;
    public float spawnRate = 15f;
    public float minY = -3.5f;
    public float maxY = 6.5f;

    // Update is called once per frame
    void Update()
    {
        spawn();
    }

    public void spawn()
    {
        float y = Random.Range(minY, maxY);
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Instantiate(powerup, new Vector3(transform.position.x, y, 0), transform.rotation);
            timer = 0;
            spawnRate = Random.Range(15f, 20f);
        }
    }
}
