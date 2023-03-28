using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpEffect : MonoBehaviour
{
    public float moveSpeed = 9;
    public float deadZone = -12;
    public float powerupDuration = 5f; // duration of the powerup effect in seconds
    public bool powerActivated = false;
    public abstract IEnumerator Apply(GameObject player);
    void Update()
    {
        if (!powerActivated) // move only if powerup is not active
            moveLeft();
        remove();
    }
    public void moveLeft()
    {
        transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
    }

    public void remove()
    {
        if (transform.position.x < deadZone && !powerActivated)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(Apply(collision.gameObject));
        }
    }
}
