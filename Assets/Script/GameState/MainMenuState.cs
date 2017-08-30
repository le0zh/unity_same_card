using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 主菜单状态
/// </summary>
public class MainMenuState : IApplicationStatus
{
    public override void OnEnterStatus()
    {
        // 当切换场景时，这种方式打开的UI会被自动关闭！
        OpenUI<MainMenuWindow>();

        // 下面这种方式打开的UI不能被自动关闭！
        // UIManager.OpenUIWindow<MainMenuWindow>();
    }
}
