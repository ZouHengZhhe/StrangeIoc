﻿using System.Collections;
using System.Collections.Generic;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine;

public interface IScoreService
{
    void RequestScore(string url); //请求分数

    void OnReceiveScore(); //收到服务器发送过来的分数

    void UpdateScore(string url, int score); //将分数更新到服务器端

    IEventDispatcher dispatcher { get; set; }
}