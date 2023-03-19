using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnScript : MonoBehaviour
{
    public GameObject coin;
    public float timer = 0;
    public float spawnRate = 2f;
    public float minY = -3f;
    public float maxY = 3f;

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
            Instantiate(coin, new Vector3(transform.position.x, y, 0), transform.rotation);
            timer = 0;
            spawnRate = Random.Range(1f, 2f);
        }
    }
}
