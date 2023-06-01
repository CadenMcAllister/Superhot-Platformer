using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TimeSlow : MonoBehaviour
{
    public float stopTime = 0.5f;
    private PlayerMovement playerMovement;
    public Rigidbody2D rb2d;
    public float upwardForce = 5f;
    public bool isActivated = false; // Add this line to declare and initialize the isActivated property

    IEnumerator StopPlayerMovement()
    {
        yield return new WaitForSeconds(stopTime);

        // Resume the player's movement
        playerMovement.speed = 10f;
    }

    void Start()
    {
        // Find the GameObject with the PlayerMovement script attached to it
        GameObject player = GameObject.Find("Player");

        rb2d = GetComponent<Rigidbody2D>();

        // Get the PlayerMovement script component
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (playerMovement.IsGrounded() && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))
        {
            if (rb2d.velocity.y < 0f)
            {
                rb2d.AddForce(Vector2.up * upwardForce, ForceMode2D.Impulse);
            }
            StartCoroutine(StopPlayerMovement());

            isActivated = true; // Set isActivated to true when the time slow effect is activated

        }
        else if (!playerMovement.IsGrounded())
        {
            // Reduce the upward force to avoid excessive bouncing
            upwardForce = 2f;
        }
        else
        {
            isActivated = false; // Set isActivated to false when the effect ends
}
    }
}
