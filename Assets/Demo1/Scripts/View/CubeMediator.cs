using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using UnityEngine;

public class CubeMediator : Mediator
{
    [Inject]//注入，strangeIoc自动注入
    public CubeView cubeView { get; set; }

    //当注入完成时调用
    public override void OnRegister()
    {
        cubeView.Init();
    }

    //当View被销毁时调用
    public override void OnRemove()
    {
        base.OnRemove();
    }
}
