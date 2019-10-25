using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

    //スコアを表示するテキスト（追加）
    private GameObject scoreText;

    //得点（追加）
    private int score = 0;

    // Use this for initialization
    void Start() {
        //シーン中のscoreTextオブジェクトを取得（追加）
        this.scoreText = GameObject.Find("ScoreText");
    }

    // Update is called once per frame
    void Update() {
        
        
    }
}