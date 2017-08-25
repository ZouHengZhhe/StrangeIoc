using System.Collections;
using System.Collections.Generic;
using strange.extensions.context.impl;
using UnityEngine;

//组件（继承MonoBehaviour）
public class Demo1ContexView : ContextView
{
    void Awake()
    {
        this.context = new Demo1Context(this); //启动StrangeIoc框架
        //context.Start(); 
    }
}