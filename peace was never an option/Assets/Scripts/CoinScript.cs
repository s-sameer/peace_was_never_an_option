using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public float moveSpeed = 9;
    public float deadZone = -16;
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    // Update is called once per frame
    void Update()
    {
        moveLeft();
        remove();
    }

    public void moveLeft()
    {
        transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
    }

    public void remove()
    {
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            logic.increaseCoins();
            Destroy(gameObject);
        }
    }

    public void Print()
    {
        Debug.Log("Working");
    }
}
