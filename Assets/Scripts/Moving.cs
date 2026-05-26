using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    public float speed = 200f;
    public float jump = 200f;
    public bool canatt = false;
    public CapsuleCollider2D capsule;
    [SerializeField] public LayerMask groundLayer;
    [SerializeField] public LayerMask wallLayer;
    public bool facingright = true;
    

    public Animator animator;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jump);
        }
    }
    private void FixedUpdate()
    {   
        float move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * speed, rb.linearVelocity.y);
        animator.SetFloat("Speed", Mathf.Abs(move));

        if (Input.GetAxis("Horizontal") > 0 && !facingright)
        { 
            Flip();
        }
        else if(Input.GetAxis("Horizontal") < 0 && facingright)
        {
            Flip();
        }
    }
    
    private void Flip()
    {

        facingright = !facingright;

        transform.Rotate(0, 180f, 0);
    }

    public bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(capsule.bounds.center, capsule.bounds.size, 0, Vector2.down, 1f, groundLayer);
        return raycastHit.collider != null;
    }

    private bool onWall()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(capsule.bounds.center, capsule.bounds.size, 0, new Vector2(transform.localScale.x, 0), 1f, wallLayer);
        return raycastHit.collider != null;
    }
    public bool canAttack()
    {
        return !onWall();
    }
}
