using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObstacleScript : MonoBehaviour
{
    public float moveSpeed = 9;
    public float deadZone = -16;

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

}
