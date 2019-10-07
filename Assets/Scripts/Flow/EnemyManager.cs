using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : IManager
{
    #region Singleton
    private static EnemyManager instance;
    private EnemyManager() { }
    public static EnemyManager Instance { get { return instance ?? (instance = new EnemyManager()); } }
    #endregion

    public void FirstInitialize()
    {
        Debug.Log("enemy manger init called");
    }

    public void PhysicsRefresh()
    {
        Debug.Log(" EnemyM physics refresh");
    }

    public void Refresh()
    {
        Debug.Log("EnemyM refresh");
    }

    public void SecondInitialize()
    {
        Debug.Log("EnemyM SecondInitialize");
        
    }
}
