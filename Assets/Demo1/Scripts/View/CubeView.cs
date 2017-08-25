using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using UnityEngine;
using UnityEngine.UI;

public class CubeView : View
{
    public Text scoreTxt;

    /// <summary>
    /// 做初始化
    /// </summary>
    public void Init()
    {
        scoreTxt = GetComponentInChildren<Text>();
    }

    void Update()
    {
        transform.Translate(new Vector3(Random.Range(-1, 2), Random.Range(-1, 2), Random.Range(-1, 2)) * 0.02f);
    }

    void OnMouseDown()
    {
        //加分
        Debug.Log("OnMouseDown!");
    }
    
    


    public void UpdateScore(int score)
    {
        scoreTxt.text = score.ToString();
    }

}