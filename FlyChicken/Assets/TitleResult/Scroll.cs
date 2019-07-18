﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    // Use this for initialization
    public float speed = 1.0f;
    public float startPosition;
    public float endPosition;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //毎フレームxポジションを少しずつ移動させる
        transform.Translate(-1 * speed * Time.deltaTime, 0, 0);

        //スクロールが目標ポイントまで行ったかをチェック
        if (transform.position.x <= endPosition) ScrollEnd();
	}
    void ScrollEnd()
    {
        //スクロールする距離分を戻す
        transform.Translate(-1 * (endPosition - startPosition), 0, 0);

        //同じゲームオブジェクトにアタッチされているコンポーネントにメッセージを送る
        SendMessage("OnScrollEnd", SendMessageOptions.DontRequireReceiver);
    }
}
