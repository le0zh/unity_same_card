using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.SceneManagement;

public class SingleGameState : IApplicationStatus
{
    public override void OnEnterStatus()
    {
        UIManager.CloseAllUI();
        SceneManager.LoadScene("Play");
        // UIManager.OpenUIWindow<MainMenuWindow>();
    }
}

