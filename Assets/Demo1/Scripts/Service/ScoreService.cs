using UnityEngine;
using System.Collections;

public class ScoreService : IScoreService
{
    //该函数要进行回调
    public void OnReceiveScore()
    {
        int score = Random.Range(0, 100);
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