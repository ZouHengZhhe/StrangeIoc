using System.Collections;
using System.Collections.Generic;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using UnityEngine;

public class CubeMediator : Mediator
{
    [Inject]//注入，strangeIoc自动注入
    public CubeView cubeView { get; set; }

    [Inject(ContextKeys.CONTEXT_DISPATCHER)] //表示是全局的dispatcher
    public IEventDispatcher dispatcher { get; set; } //用于模块与模块之间事件的传递与调用
    

    //当注入完成时调用
    public override void OnRegister()
    {
        cubeView.Init();

        dispatcher.AddListener(Demo1MediatorEvent.ScoreChange, OnScoreChange);
        cubeView.dispatcher.AddListener(Demo1MediatorEvent.ClickDown,OnClickDown);
        //通过dispatcher，发起请求分数的命令
        dispatcher.Dispatch(Demo1CommandEvent.RequestScore);
    }

    //当View被销毁时调用
    public override void OnRemove()
    {
        dispatcher.RemoveListener(Demo1MediatorEvent.ScoreChange, OnScoreChange);
        cubeView.dispatcher.RemoveListener(Demo1MediatorEvent.ClickDown, OnClickDown);
    }

    public void OnScoreChange(IEvent evt)
    {
        cubeView.UpdateScore((int)evt.data);
    }

    public void OnClickDown()
    {
        dispatcher.Dispatch(Demo1CommandEvent.UpdateScore); 
    }

}
