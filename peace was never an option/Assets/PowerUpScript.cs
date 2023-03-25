using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = -12;
    public bool powerActivated = false;
    public float powerupDuration = 5f; // duration of the powerup effect in seconds

    private Collider2D playerCollider; // store player's collider to toggle collision

    private void Start()
    {
        playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
    }

    // Update is called once per frame
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
            StartCoroutine(power(collision));
        }
    }

    IEnumerator power(Collider2D player)
    {
        powerActivated = true;

        // disable collision with obstacle layer
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Obstacle"), true);

        GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(powerupDuration);

        // reset collision with obstacle layer
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Obstacle"), false);

        powerActivated = false;
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        // reset collision with obstacle layer when powerup is destroyed
        Physics2D.IgnoreLayerCollision(LayerMask.NameToLayer("Player"), LayerMask.NameToLayer("Obstacle"), false);
    }
}
