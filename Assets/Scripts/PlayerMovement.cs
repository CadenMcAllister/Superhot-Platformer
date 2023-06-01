using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    public float speed = 8f;
    private float jumpingPower = 18f;

    public GameObject m_GotHitScreen;
    [SerializeField] private Rigidbody2D rb;
    public GameObject groundCheck;
    [SerializeField] private LayerMask groundLayer;
public bool IsGrounded()
{
    return Physics2D.OverlapCircle(groundCheck.transform.position, groundLayer);
}

private void OnCollisionEnter(Collision collision){
    if(collision.gameObject.tag == "cube"){
        gothurt();
    }
}

void gothurt()
{
    var color = m_GotHitScreen.GetComponent<Image>().color;
    color.a = 0.8f;

    m_GotHitScreen.GetComponent<Image>().color = color;
}

void Update()
{
    horizontal = Input.GetAxisRaw("Horizontal");

    if (Input.GetButtonDown("Jump") && IsGrounded())
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
    }

    if (Input.GetButtonUp("Jump") && rb.velocity.y == 0f)
    {
        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.1f);
    }

    rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

}
}

