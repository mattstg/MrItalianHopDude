using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void FirstInitialize()
    {
    }

    public void PhysicsRefresh(InputManager.InputPkg playerInput)
    {
        Debug.Log(playerInput);
    }

    public void Refresh(InputManager.InputPkg playerInput)
    {
    }

    public void SecondInitialize()
    {
    }
}
