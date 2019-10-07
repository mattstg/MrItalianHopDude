using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    public float moveSpeed = 5;
    public float maxSpeed = 7;
    public float initialJumpForce = 10;

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
        if(jumpPressed && CheckIsGroundedRaycast())
            rb.AddForce(Vector2.up * initialJumpForce, ForceMode2D.Impulse);
    }

    public void Refresh(InputManager.InputPkg playerInput)
    {

    }

    public void SecondInitialize()
    {
    }
}
