using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float playerSpeed;
    [SerializeField] float jumpForce;

    void Start()
    {
        
    }


    void Update()
    {
        movement();
        transform.Translate(new Vector3(0, -0.5f, 0) * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jump" && collision.relativeVelocity.y >= 0)
        {
            Jump();
        }
    }
    private void movement()
    {
        float xInput = Input.GetAxis("Horizontal");
;       rb.velocity = new Vector3(xInput * playerSpeed, rb.velocity.y, 0);
    }
    private void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0);
    }
}
