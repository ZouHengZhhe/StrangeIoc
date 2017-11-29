using System.Collections;
using System.Collections.Generic;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using UnityEngine;
using UnityEngine.UI;

public class CubeView : View
{
    [Inject]
    public IEventDispatcher dispatcher { get; set; }

    [Inject]
    public AudioManager audioManager { get; set; }

    public Text scoreTxt;

    /// <summary>
    /// 做初始化
    /// </summary>
    public void Init()
    {
        scoreTxt = GetComponentInChildren<Text>();
    }

    private void Update()
    {
        transform.Translate(new Vector3(Random.Range(-1, 2), Random.Range(-1, 2), Random.Range(-1, 2)) * 0.02f);
    }

    private void OnMouseDown()
    {
        //加分
        Debug.Log("OnMouseDown!");
        audioManager.Play("Hit");
        dispatcher.Dispatch(Demo1MediatorEvent.ClickDown);
    }

    public void UpdateScore(int score)
    {
        scoreTxt.text = score.ToString();
    }
}