using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBucket : MonoBehaviour
{
    public float gravity = -5.5f;
    public float maxFallSpeed = -10f;
    public float groundY = 0f;

    private Vector3 velocity = Vector3.zero;
    private bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ApplyGravity();
        Move();
        Grounded();
    }

    void ApplyGravity()
    {
        if (!isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
            velocity.y = Mathf.Clamp(velocity.y, maxFallSpeed, Mathf.Infinity);
        }
    }

    void Move()
    {
        transform.position += velocity * Time.deltaTime;
    }

    void Grounded()
    {
        if(transform.position.y <= groundY)
        {
            isGrounded = true;
            transform.position =
                new Vector3(transform.position.x, groundY, transform.position.z);
        }
    }
}
