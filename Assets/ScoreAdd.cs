using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreAdd : MonoBehaviour {

    //得点を表示するテキスト
    private GameObject scoreText;
    //得点を計算する整数
    private int score = 0;
    //固定文字
    private string scoreWord = "Score : ";

    // Use this for initialization
    void Start () {
        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
        //ScoreTextを初期化
        this.scoreText.GetComponent<Text>().text = scoreWord + this.score.ToString();
    }

    // Update is called once per frame
    void Update () {
    }

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {
        // タグによって加算する得点を変える
        if (other.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
        }
        else if (other.gameObject.tag == "LargeStarTag" || other.gameObject.tag == "SmallCloudTag")
        {
            this.score += 20;
        }
        else if (other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 30;
        }

        //得点を加算し、ScoreTextに表示
        this.scoreText.GetComponent<Text>().text = scoreWord + this.score.ToString();
    }
}
