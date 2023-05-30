using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public float jumpForce = 3f;

    private Rigidbody2D rb;

    private SpriteRenderer spriteRenderer;


    #region AnimationHandler
    public Animator animator;
    private void PlayWalk()
    {
        animator.SetBool("goWalk", true);
    }
    private void PlayJump()
    {
        animator.SetTrigger("goJump");
    }
    #endregion

    void Start()
    {
        // Ambil komponen rigidbody dari objek player
        rb = GetComponent<Rigidbody2D>();
        animator.GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void SpriteFlip(float horizontalInput)
    {
        if (horizontalInput < 0)
        {
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(horizontalInput * speed * Time.deltaTime, 0f, 0f));
        SpriteFlip(horizontalInput);

        if ( Mathf.Abs(rb.velocity.y) < 0.001f )
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                PlayJump();
            }

            else if (horizontalInput != 0f)
            {
                PlayWalk();
            }
            else if(horizontalInput == 0)
            {
                animator.SetBool("goWalk", false);
            }

        }
        
    }
}
