using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    // 「Hello」に続けて引数の文字列を表示する関数
    void HelloName(string name)
    {
        Debug.Log("Hello, " + name);
    }

    void Start()
    {
        // HelloName関数に「Unity」という引数を渡す
        HelloName("Unity");
    }

    // Update is called once per frame
    void Update()
    {

    }
}



[]
//トリガーモードで他のオブジェクトと接触した場合の処理
void OnCollisionEnter(Collision collision);
        {
            //大きい雲に衝突した場合
            if (other.gameObject.tag == "LargeCloudTag")
            {

                // スコアを加算(追加)
                this.score += 30;
            }

            //小さい雲に衝突した場合
            if (other.gameObject.tag == "SmallCloudTag")
            {
                // スコアを加算(追加)
                this.score += 20;
            }

            //小さい星に衝突した場合
            if (other.gameObject.tag == "SmallStarTag")
            {
                // スコアを加算(追加)
                this.score += 10;
            }

            //大きい星に衝突した場合
            if (other.gameObject.tag == "SmallStarTag")
            {
                // スコアを加算(追加)
                this.score += 20;
            }

            //ScoreText獲得した点数を表示(追加)
            this.scoreText.GetComponent<Text>().text = "Score " + this.score + "pt";

            //ボールが画面外に出た場合
            if (this.transform.position.z< this.visiblePosZ)
            {


    //GameoverTextにゲームオーバを表示
    this.gameoverText.GetComponent<Text>().text = "Game Over";
