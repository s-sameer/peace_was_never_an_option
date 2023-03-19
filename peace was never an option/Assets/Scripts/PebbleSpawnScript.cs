using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PebbleSpawnScript : MonoBehaviour
{
    public GameObject pebble;
    public float timer = 0;
    public float spawnRate = 0.5f;

    // Update is called once per frame
    void Update()
    {
        spawn();
    }

    public void spawn()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Instantiate(pebble, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
            timer = 0;
            spawnRate = Random.Range(1f, 2f);
        }
    }
}
