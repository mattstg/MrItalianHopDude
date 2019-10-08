using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    public float moveSpeed = 5;
    public float maxSpeed = 7;
    public float initialJumpForce = 10;
    public float holdJumpForce = 6;
    HashSet<Collider2D> groundObjectsTouching = new HashSet<Collider2D>();
    private bool isGrounded { get { return groundObjectsTouching.Count > 0; } }
    float timeLastJumped;
    float jumpCooldown = .5f;
    float timeCanHoldJump = 1f;
    bool firstGroundTouch = false;

    public void FirstInitialize()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void PhysicsRefresh(InputManager.InputPkg playerInput)
    {
        rb.AddForce(Vector2.right * playerInput.dirPressed * moveSpeed);
        Vector2 velo = new Vector2(Mathf.Clamp(rb.velocity.x,-maxSpeed,maxSpeed),rb.velocity.y);
        rb.velocity = velo;

        Jump(playerInput.jumpPressed, playerInput.jumpHeld);

    }
    
    private bool CheckIsGroundedRaycast()
    {
        return Physics2D.Raycast(transform.position, -transform.up, 1.1f, LayerMask.GetMask("Ground"));
    }

    private void Jump(bool jumpPressed, bool jumpHeld)
    {
        if (jumpPressed && isGrounded && (Time.time - timeLastJumped) > jumpCooldown)
        {
            rb.AddForce(Vector2.up * initialJumpForce, ForceMode2D.Impulse);
            timeLastJumped = Time.time;
        }
        if(jumpHeld && Time.time - timeLastJumped < timeCanHoldJump )
        {
            rb.AddForce(Vector2.up * holdJumpForce);
        }

    }

    public void Refresh(InputManager.InputPkg playerInput)
    {

    }

    public void SecondInitialize()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D coli)
    {
        if (!groundObjectsTouching.Contains(coli.collider))
        {
            groundObjectsTouching.Add(coli.collider);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        groundObjectsTouching.Remove(collision.collider);
    }
}
