using strange.extensions.context.impl;
using System;
using System.Collections.Generic;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using UnityEngine;

public class Demo1Context:MVCSContext
{
    public Demo1Context(MonoBehaviour view):base(view){ }

    protected override void mapBindings() //进行绑定映射
    {
        //model

        //service

        //command

        //mediator

        //绑定开始事件 创建一个startcommand
        commandBinder.Bind(ContextEvent.START).To<StartCommand>();

    }

}