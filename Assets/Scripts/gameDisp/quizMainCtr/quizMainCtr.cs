using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quizMainCtr : MonoBehaviour
{
    public Text QuizText;
    // quiz�I���̃X�^�b�N
    static int[] StackChosenQuiz = new int[quizData.quizDataBufNum];
    // �p�l�������I���̃X�^�b�N
    static int[] StackChosenAns = new int[PanelData.speedPatTableNum];
    static int[] StackChosenPanel = new int[PanelData.speedPatTableNum];
    static int[] Stackrandom11num4Ans = new int[PanelData.speedPatTableNum];

    //static int prefabDispCount = 1;
    //static int prefabDispTimer = 0;


    // Start is called before the first frame update
    void Start()
    {
        //quizData������
        quizData.quizDataInit();

        //quizData�쐬�@�����ł͂Ȃ����Ƃ͂킩��
        quizData.quizDataMake();

        LogquizDataDisp();

        quizMainCtrInitSequence();
    }

    public void quizMainCtrInitSequence()
    {
        //quizData�������E�쐬��̏���
        //quizData�����������鏈���ł͂Ȃ�
        GetComponent<PanelControler>().PanelDataInit();

        AnswerBuffer.answerBuffInit();

        //QuizText�̕\��
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
            Debug.Log("StackChosenQuiz[" + i + "]�F" + StackChosenQuiz[i]);
            //���ł�quizDataBuf�̃f�[�^���ݒ肵�Ă݂�
            Debug.Log("quizData.quizDataBuf[" + i + ", 0])�F" + quizData.quizDataBuf[i, 0]);  //���
            Debug.Log("quizData.quizDataBuf[" + i + ", 1])�F" + quizData.quizDataBuf[i, 1]);  //����1
            Debug.Log("quizData.quizDataBuf[" + i + ", 2])�F" + quizData.quizDataBuf[i, 2]);  //����2
            Debug.Log("quizData.quizDataBuf[" + i + ", 3])�F" + quizData.quizDataBuf[i, 3]);  //����3
            Debug.Log("quizData.quizDataBuf[" + i + ", 4])�F" + quizData.quizDataBuf[i, 4]);  //����4
        }
    }

}
