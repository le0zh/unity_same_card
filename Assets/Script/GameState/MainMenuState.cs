using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class MainMenuState : IApplicationStatus
{
    public override void OnEnterStatus()
    {
        UIManager.OpenUIWindow<MainMenuWindow>();
    }
}
