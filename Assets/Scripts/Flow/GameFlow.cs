using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow
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

    public void SampleFunc() { }
    
}
