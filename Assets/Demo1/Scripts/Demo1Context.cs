using strange.extensions.context.impl;
using System;
using System.Collections.Generic;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using UnityEngine;

//非Component组件（未继承MonoBehaviour）
public class Demo1Context : MVCSContext
{
    public Demo1Context(MonoBehaviour view) : base(view)
    {
    }

    protected override void mapBindings() //进行绑定映射
    {
        //model

        //service

        //command

        //mediator
        mediationBinder.Bind<CubeView>().To<CubeMediator>();//完成View和Mediator的绑定

        //绑定开始事件 创建一个startcommand
        commandBinder.Bind(ContextEvent.START).To<StartCommand>().Once();
    }
}