using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum MoveType { Velo, Forces}

    Rigidbody2D rb;
    public float moveSpeed = 5;
    public float maxSpeed = 7;
    public MoveType moveType = MoveType.Forces;
    public void FirstInitialize()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void PhysicsRefresh(InputManager.InputPkg playerInput)
    {
        switch (moveType) //sw tab tab varname enter enter
        {
            case MoveType.Velo:
                rb.velocity = new Vector2(playerInput.dirPressed.x * moveSpeed, rb.velocity.y);
                break;
            case MoveType.Forces:
                rb.AddForce(Vector2.right * playerInput.dirPressed * moveSpeed);
                Vector2 velo = new Vector2(Mathf.Clamp(rb.velocity.x,-maxSpeed,maxSpeed),rb.velocity.y);
                rb.velocity = velo;
                break;
            default:
                Debug.LogError("Unhandled switch: " + moveType);
                break;
        }
        
    }

    public void Refresh(InputManager.InputPkg playerInput)
    {

    }

    public void SecondInitialize()
    {
    }
}
