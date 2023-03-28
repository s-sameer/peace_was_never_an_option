using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnScript : MonoBehaviour
{
    public GameObject obstacle;
    public float timer = 0;
    public float spawnRate = 1f;
    public float minY = -3.5f;
    public float maxY = 7f;
    public GameObject[] obstaclesToSpawn;

    void Start()
    {
        obstaclesToSpawn = new GameObject[2];
        obstaclesToSpawn[0] = Resources.Load<GameObject>("Spike");
        obstaclesToSpawn[1] = Resources.Load<GameObject>("Helicopter");
    }

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
        } else
        {
            int index = Random.Range(0, obstaclesToSpawn.Length);
            GameObject obstacleToSpawn = obstaclesToSpawn[index];
            Instantiate(obstacleToSpawn, new Vector3(transform.position.x, y, 0), transform.rotation);
            timer = 0;
            spawnRate = Random.Range(0.5f, 1.5f);
        }
    }
}
