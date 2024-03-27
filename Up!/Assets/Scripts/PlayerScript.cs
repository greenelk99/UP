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
    
    private void movement()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = rb.velocity.y;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            yInput = jumpForce;
        }
        rb.velocity = new Vector3(xInput * playerSpeed, yInput, 0);
    }
}
