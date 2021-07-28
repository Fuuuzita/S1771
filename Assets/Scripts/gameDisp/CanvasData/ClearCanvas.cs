using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearCanvas : MonoBehaviour
{
    //パネルを登録する
    public GameObject panel;
    //リトライボタン
    public GameObject retryButton;
    //メインメニューボタン
    public GameObject mainmenuButton;
    //スコア
    public GameObject scoreText;
    public GameObject scoreMesText;


    // Start is called before the first frame update
    void Start()
    {
        //パネルを隠す
        panel.SetActive(false);
        //リトライボタンを隠す
        retryButton.SetActive(false);
        //メインメニューボタンを隠す
        mainmenuButton.SetActive(false);
        //スコア
        scoreText.SetActive(false);
        scoreMesText.SetActive(false);
    }

    //クリアパネルを表示させる
    void DispClearPanel()
    {
        //パネルを表示させる
        panel.SetActive(true);
        //リトライボタンを隠す
        retryButton.SetActive(true);
        //メインメニューボタンを隠す
        mainmenuButton.SetActive(true);
        //スコア
        scoreText.SetActive(true);
        scoreMesText.SetActive(true);

    }
}
