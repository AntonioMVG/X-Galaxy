using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*******************/
    // Private variables
    /*******************/
    private GameManager gameManager;
    private Rigidbody2D rb;
    private int leftShootings = 0;
    private int rightShootings = 0;

    /******************/
    // Public variables
    /******************/
    public int speed;
    public Transform fireLeft;
    public Transform fireRight;
    public GameObject misilePrefab;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // Get the value from -1 to 1 of the horizontal move
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // Apply physic velocity to the object with the move value * speed, the Y coordenate is the same
        rb.velocity = new Vector2(inputX * speed, inputY * speed);
        //rb.velocity = new Vector2(inputX * speed, rb.velocity.y);
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1") && leftShootings <= 9 && rightShootings <= 9)
        {
            LeftShoot();
            RightShoot();
        }
    }

    void LeftShoot()
    {
        Instantiate(misilePrefab, fireLeft.position, fireLeft.rotation);
        leftShootings += 1;
    }

    void RightShoot()
    {
        Instantiate(misilePrefab, fireRight.position, fireRight.rotation);
        rightShootings += 1;
    }
}
