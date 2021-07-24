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

    //static int prefabDispCount = 1;
    //static int prefabDispTimer = 0;


    // Start is called before the first frame update
    void Start()
    {
        //quizData初期化
        quizData.quizDataInit();

        //quizData作成　ここではないことはわかる
        quizData.quizDataMake();

        LogquizDataDisp();

        quizMainCtrInitSequence();
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
    }

    // Update is called once per frame
    void Update()
    {
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

}
