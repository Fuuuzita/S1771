using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quizMainCtr : MonoBehaviour
{
    public Text QuizText;
    // quiz選択のスタック
    static int[] StackChosenQuiz = new int[quizData.quizDataBufNum];
    // パネル数字選択のスタック
    static int[] StackChosenAns = new int[PanelData.speedPatTableNum];
    static int[] StackChosenPanel = new int[PanelData.speedPatTableNum];
    static int[] Stackrandom11num4Ans = new int[PanelData.speedPatTableNum];

    static int NextQuizTimer = 0;   //対応が雑になってきた
    //クリアパネルを追加する
    public GameObject clearCanvas;
    //クリアパネル呼び出しフラグ
    static bool clearCanvasDispFlg = true;
    //START
    public GameObject STARTObject;

    // Start is called before the first frame update
    void Start()
    {
        STARTObjectDisp();
        //quizData初期化
        quizData.quizDataInit();
        NowQuizCount.ClearCount();

        //quizData作成　ここではないことはわかる
        quizData.quizDataMake();

        LogquizDataDisp();

        quizMainCtrInitSequence();

        clearCanvasDispFlg = true;
    }

    public void quizMainCtrInitSequence()
    {
        //quizData初期化・作成後の処理
        //quizDataを初期化する処理ではない
        GetComponent<PanelControler>().PanelDataInit();

        AnswerBuffer.answerBuffInit();

        //QuizTextの表示
        QuizText.text = quizData.GetquizDataBuf(0);

        GetComponent<AnswerTouchEvent>().AnswerTouchEventInit();
        GetComponent<CheckAnswerCtrl>().CheckAnswerCtrlInit();

        //現在問題数を進める
        NowQuizCount.NextCount();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        //だいぶ適当になってきた
        //解答が終わったときにこのフラグが立つはずだから
        //このフラグを見る
        if (PanelData.GetdelPanelFlg())
        {
            //最後の問題まで来たら終わり
            if((quizData.quizDataBufNum　-1) != quizData.GetquizDataNowPos())
            {
                //次の問題へ
                //ちょっと待って初期化する
                if (NextQuizTimer > 100)
                {
                    quizData.NextquizDataNowPos();
                    quizMainCtrInitSequence();
                    NextQuizTimer = 0;
                }
                else
                {
                    NextQuizTimer++;
                }
            }
            else
            {
                if(clearCanvasDispFlg)
                {
                    clearCanvasDispFlg = false;
                    //ClearPanelを表示するよー
                    Invoke("DispClearPanelSend", 2);
                }
            }
        }
    }

    void LogquizDataDisp()
    {
        int i;                  //For loop
        for (i = 0; i < quizData.quizDataBufNum; i++)
        {
            Debug.Log("StackChosenQuiz[" + i + "]：" + StackChosenQuiz[i]);
            //ついでにquizDataBufのデータも設定してみる
            Debug.Log("quizData.quizDataBuf[" + i + ", 0])：" + quizData.quizDataBuf[i, 0]);  //問題
            Debug.Log("quizData.quizDataBuf[" + i + ", 1])：" + quizData.quizDataBuf[i, 1]);  //答え1
            Debug.Log("quizData.quizDataBuf[" + i + ", 2])：" + quizData.quizDataBuf[i, 2]);  //答え2
            Debug.Log("quizData.quizDataBuf[" + i + ", 3])：" + quizData.quizDataBuf[i, 3]);  //答え3
            Debug.Log("quizData.quizDataBuf[" + i + ", 4])：" + quizData.quizDataBuf[i, 4]);  //答え4
        }
    }

    void DispClearPanelSend()
    {
        //クリアパネルにメッセージを送信する
        clearCanvas.SendMessage("DispClearPanel");

    }

    void STARTObjectDisp()
    {
        Vector3 newPos = this.transform.position;

        newPos.x = 6;
        newPos.y = 1;
        newPos.z = -5; // 手前に表示

        GameObject newGameObject = Instantiate(STARTObject) as GameObject;
        newGameObject.transform.position = newPos;
    }

}
