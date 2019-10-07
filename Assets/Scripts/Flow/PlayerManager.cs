using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : IManager
{
    #region Singleton
    private static PlayerManager instance;
    private PlayerManager() { }
    public static PlayerManager Instance { get { return instance ?? (instance = new PlayerManager()); } }
    #endregion

    public void FirstInitialize()
    {
        Debug.Log("PlayerManager init called");
    }

    public void PhysicsRefresh()
    {
        Debug.Log(" PlayerManager physics refresh");
    }

    public void Refresh()
    {
        Debug.Log("PlayerManager refresh");
    }

    public void SecondInitialize()
    {
        Debug.Log("PlayerManager SecondInitialize");
        
    }
}
