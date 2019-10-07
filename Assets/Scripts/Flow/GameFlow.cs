using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : IManagable
{
    #region Singleton
    private static GameFlow instance = null;

    private GameFlow()
    {
    }

    public static GameFlow Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameFlow();
            }
            return instance;
        }
    }

    #endregion

    
    public void FirstInitialize()
    {
        GameLinks.gl = GameObject.FindObjectOfType<GameLinks>();
        InputManager.Instance.FirstInitialize();
        PlayerManager.Instance.FirstInitialize();
        EnemyManager.Instance.FirstInitialize();
    }

    public void PhysicsRefresh()
    {
        InputManager .Instance.PhysicsRefresh();
        PlayerManager.Instance.PhysicsRefresh();
        EnemyManager .Instance.PhysicsRefresh();
    }

    public void Refresh()
    {
        InputManager.Instance .Refresh();
        PlayerManager.Instance.Refresh();
        EnemyManager.Instance .Refresh();
    }

    public void SecondInitialize()
    {
        InputManager .Instance.SecondInitialize();
        PlayerManager.Instance.SecondInitialize();
        EnemyManager .Instance.SecondInitialize();
    }
}
