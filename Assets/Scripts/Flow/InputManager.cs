using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : IManager
{
    #region Singleton
    private static InputManager instance;
    private InputManager() { }
    public static InputManager Instance { get { return instance ?? (instance = new InputManager()); } }
    #endregion

    public void FirstInitialize()
    {
        Debug.Log("InputManager init called");
    }

    public void PhysicsRefresh()
    {
        Debug.Log(" InputManager physics refresh");
    }

    public void Refresh()
    {
        Debug.Log("InputManager refresh");
    }

    public void SecondInitialize()
    {
        Debug.Log("InputManager SecondInitialize");
        
    }
}
