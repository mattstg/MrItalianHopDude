using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : IManagable
{
    #region Singleton
    private static PlayerManager instance;
    private PlayerManager() { }
    public static PlayerManager Instance { get { return instance ?? (instance = new PlayerManager()); } }
    #endregion
    public Player player;
    public void FirstInitialize()
    {
        GameObject newPlayer = GameObject.Instantiate(Resources.Load<GameObject>("Prefabs/Player"));
        player = newPlayer.GetComponent<Player>();
        player.transform.position = GameLinks.gl.playerSpawn.position;
        player.FirstInitialize();
    }

    public void PhysicsRefresh()
    {
        player.PhysicsRefresh(InputManager.Instance.physicsRefreshInputPkg);
    }

    public void Refresh()
    {
        player.Refresh(InputManager.Instance.refreshInputPkg);
    }

    public void SecondInitialize()
    {
        player.SecondInitialize();
    }
}
