﻿using UnityEngine;
using System.Collections;

public class MainMenuWindow : UIWindowBase
{
    //UI的初始化请放在这里
    public override void OnInit()
    {
        Debug.Log("Init");
    }

    //请在这里写UI的更新逻辑，当该UI监听的事件触发时，该函数会被调用
    public override void OnRefresh()
    {

    }

    //UI的进入动画
    public override IEnumerator EnterAnim(UIAnimCallBack l_animComplete, UICallBack l_callBack, params object[] objs)
    {
        //AnimSystem.uguiAlpha(gameObject, 0, 1, 1, InteType.Linear, true,(object[] obj)=>
        //{
        //    l_animComplete(this, l_callBack, objs);
        //});

        yield return new WaitForEndOfFrame();
    }

    //UI的退出动画
    public override IEnumerator ExitAnim(UIAnimCallBack l_animComplete, UICallBack l_callBack, params object[] objs)
    {
        //AnimSystem.uguiAlpha(gameObject, 1, 0, 1, InteType.Linear, true, (object[] obj) =>
        //{
        //    l_animComplete(this, l_callBack, objs);
        //});

        yield return new WaitForEndOfFrame();
    }
}