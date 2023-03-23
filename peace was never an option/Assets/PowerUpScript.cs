using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public float moveSpeed = 10;
    public float deadZone = -12;
    public bool powerActivated = false;
    
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
        if (transform.position.x < deadZone && !powerActivated)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        powerActivated = true;
        if (collision.CompareTag("Player"))
        {
            StartCoroutine(power(collision));
        }
    }

    IEnumerator power(Collider2D player)
    {
        player.GetComponent<BoxCollider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
        yield return new WaitForSeconds(5);
        player.GetComponent<BoxCollider2D>().enabled = true;
        Destroy(gameObject);
    }

}
