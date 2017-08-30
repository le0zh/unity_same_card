using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.SceneManagement;

/// <summary>
/// 单人游戏
/// </summary>
public class SingleGameState : IApplicationStatus
{
    public override void OnEnterStatus()
    {
        // SceneManager.LoadScene("Play");
        UIManager.OpenUIWindow<CountDownWindow>();
    }

    public void FinishCountDown()
    {
        GameLogic.Init();

        CloseUI<CountDownWindow>();
    }
}

