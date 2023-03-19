using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // You need to create references to components you want to modify in the object
    public Rigidbody2D myRigidBody;
    public LogicScript logic;
    public Animator animator;
    public float flapStrength=6;
    public bool playerIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        if (playerIsAlive)
        {
            logic.increaseScore();
        }
        if (transform.position.y > 8)
        {
            logic.gameOver();
            playerIsAlive = false;
        }
    }

    public void move()
    {
        if ((Input.GetKeyDown(KeyCode.Space)) || (Input.GetKeyDown(KeyCode.UpArrow)))
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
            animator.SetBool("touchingGround", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            playerIsAlive = false;
            logic.gameOver();
        }

        if (collision.gameObject.layer == 8)
        {
            animator.SetBool("touchingGround", true);
        }
    }

}
