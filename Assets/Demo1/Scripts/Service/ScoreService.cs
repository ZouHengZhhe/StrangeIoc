using UnityEngine;
using System.Collections;
using strange.extensions.dispatcher.eventdispatcher.api;
using System;

public class ScoreService : IScoreService
{
    [Inject]
    public IEventDispatcher dispatcher { get; set; }

    //该函数要进行回调
    public void OnReceiveScore()
    {
        int score = UnityEngine.Random.Range(0, 100);
        dispatcher.Dispatch(Demo1ServiceEvent.RequestScore,score);
    }

    public void RequestScore(string url)
    {
        Debug.Log("Request score from url:" + url);
        OnReceiveScore();
    }

    public void UpdateScore(string url, int score)
    {
        Debug.Log("Update score to url:" + url + " new  score:" + score);
    }
}