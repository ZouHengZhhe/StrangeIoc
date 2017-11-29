using System.Collections;
using System.Collections.Generic;
using strange.extensions.command.impl;
using UnityEngine;

//开始命令
public class StartCommand : Command
{
    [Inject]
    public AudioManager audioManager { get; set; }

    //当这个命令被执行的时候，默认会调用Execute方法
    public override void Execute()
    {
        //manager init
        audioManager.Init();
    }
}