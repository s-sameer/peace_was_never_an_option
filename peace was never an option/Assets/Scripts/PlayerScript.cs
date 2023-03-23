using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // You need to create references to components you want to modify in the object
    public Rigidbody2D myRigidBody;
    public LogicScript logic;
    public Animator animator;
    public float flapStrength=7;
    public bool playerIsAlive = true;
    public GameObject obstacle;

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
        if(logic.score>1 && (int)logic.score % 50 == 0)
        {
            Time.timeScale += 0.002f;
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
        // Collision with obstacle
        if (collision.gameObject.layer == 6)
        {
            playerIsAlive = false;
            logic.gameOver();
        }

        // Collision with ground
        if (collision.gameObject.layer == 8)
        {
            animator.SetBool("touchingGround", true);
        }
    }

}
