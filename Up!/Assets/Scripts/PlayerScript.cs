using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] GameObject plattform;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float playerSpeed;
    [SerializeField] float jumpForce;

    void Start()
    {
        
    }


    void Update()
    {
        Movement();
        transform.Translate(new Vector3(0, -0.5f, 0) * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Jump" && collision.relativeVelocity.y >= 0)
        {
            Jump();
            SpawnPlattform();
        }
    }
    private void Movement()
    {
        float xInput = Input.GetAxis("Horizontal");
;       rb.velocity = new Vector3(xInput * playerSpeed, rb.velocity.y, 0);
    }
    private void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, 0);
    }

    private void SpawnPlattform()
    {
        for (int i = 0; i < 3; i++)
        {
            Instantiate(plattform, new Vector3(Random.Range(-8f, 8f), Random.Range(gameObject.transform.position.y, gameObject.transform.position.y + 5f), 0), Quaternion.identity);
        }
    }
}
