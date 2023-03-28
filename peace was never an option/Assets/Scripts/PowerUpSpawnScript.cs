using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawnScript : MonoBehaviour
{
    public float timer = 0;
    public float spawnRate = 12f;
    public float minY = -3.5f;
    public float maxY = 6.5f;
    public GameObject[] powerUpsToSpawn;

    void Start()
    {
        powerUpsToSpawn = new GameObject[3];
        powerUpsToSpawn[0] = Resources.Load<GameObject>("DisableObs");
        powerUpsToSpawn[1] = Resources.Load<GameObject>("FlapIncrease");
        powerUpsToSpawn[2] = Resources.Load<GameObject>("SpeedUp");
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
        }
        else
        {
            int index = Random.Range(0, powerUpsToSpawn.Length);
            GameObject powerUpToSpawn = powerUpsToSpawn[index];
            Instantiate(powerUpToSpawn, new Vector3(transform.position.x, y, 0), transform.rotation);
            timer = 0;
            spawnRate = Random.Range(10f, 15f);
        }
    }
}
