using UnityEngine;
using System.Collections;
using System.Text;

public class MainMenuWindow : UIWindowBase
{
    //UI的初始化请放在这里
    public override void OnInit()
    {
        AddOnClickListener("StartGameButton", ClickStartGame);
    }

    //请在这里写UI的更新逻辑，当该UI监听的事件触发时，该函数会被调用
    public override void OnRefresh()
    {

    }

    ////UI的进入动画
    //public override IEnumerator EnterAnim(UIAnimCallBack l_animComplete, UICallBack l_callBack, params object[] objs)
    //{
    //    AnimSystem.UguiAlpha(gameObject, 0, 1, callBack: (object[] obj) =>
    //    {
    //        StartCoroutine(base.EnterAnim(l_animComplete, l_callBack, objs));
    //    });

    //    yield return new WaitForEndOfFrame();
    //}

    ////UI的退出动画
    //public override IEnumerator ExitAnim(UIAnimCallBack l_animComplete, UICallBack l_callBack, params object[] objs)
    //{
    //    AnimSystem.UguiAlpha(gameObject, null, 0, callBack: (object[] obj) =>
    //    {
    //        StartCoroutine(base.ExitAnim(l_animComplete, l_callBack, objs));
    //    });

    //    yield return new WaitForEndOfFrame();
    //}

    public void ClickStartGame(InputUIOnClickEvent e)
    {
        Debug.Log("Start Game");
        //var cards = CardService.GetQuestions(10);
        //StringBuilder sb = new StringBuilder();
        //cards.ForEach((i) =>
        //{
        //    sb.Append(i + ",");
        //});
        //Debug.Log(sb.ToString());
        ApplicationStatusManager.EnterStatus<SingleGameState>();
    }
}