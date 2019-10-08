using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : IManagable
{
    #region Singleton
    private static UIManager instance;
    private UIManager() { }
    public static UIManager Instance { get { return instance ?? (instance = new UIManager()); } }
    #endregion

    Player p;
    public void FirstInitialize()
    {
        p = PlayerManager.Instance.player;
    }

    public void PhysicsRefresh()
    {
    }

    public void Refresh()
    {
        Player.PlayerUIPkg uipkg = p.GetUIPkg();
        ProcessPkg(uipkg);
    }

    private void ProcessPkg(Player.PlayerUIPkg uipkg)
    {
        UILinks.instance.liveText.text = uipkg.numOfLives.ToString();
        UILinks.instance.lifeBar.fillAmount = uipkg.lifePercentage;
        UILinks.instance.lifeBar.color = Color.Lerp(Color.red, Color.green, uipkg.lifePercentage);
    }

    public void SecondInitialize()
    {
        
    }
}
