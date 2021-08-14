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

    static int NextQuizTimer = 0;   //�Ή����G�ɂȂ��Ă���
    //�N���A�p�l����ǉ�����
    public GameObject clearCanvas;
    //�N���A�p�l���Ăяo���t���O
    static bool clearCanvasDispFlg = true;
    //START
    public GameObject STARTObject;

    // Start is called before the first frame update
    void Start()
    {
        STARTObjectDisp();
        //quizData������
        quizData.quizDataInit();
        NowQuizCount.ClearCount();

        //quizData�쐬�@�����ł͂Ȃ����Ƃ͂킩��
        quizData.quizDataMake();

        LogquizDataDisp();

        quizMainCtrInitSequence();

        clearCanvasDispFlg = true;
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

        //���ݖ�萔��i�߂�
        NowQuizCount.NextCount();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        //�����ԓK���ɂȂ��Ă���
        //�𓚂��I������Ƃ��ɂ��̃t���O�����͂�������
        //���̃t���O������
        if (PanelData.GetdelPanelFlg())
        {
            //�Ō�̖��܂ŗ�����I���
            if((quizData.quizDataBufNum�@-1) != quizData.GetquizDataNowPos())
            {
                //���̖���
                //������Ƒ҂��ď���������
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
                    //ClearPanel��\�������[
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
            Debug.Log("StackChosenQuiz[" + i + "]�F" + StackChosenQuiz[i]);
            //���ł�quizDataBuf�̃f�[�^���ݒ肵�Ă݂�
            Debug.Log("quizData.quizDataBuf[" + i + ", 0])�F" + quizData.quizDataBuf[i, 0]);  //���
            Debug.Log("quizData.quizDataBuf[" + i + ", 1])�F" + quizData.quizDataBuf[i, 1]);  //����1
            Debug.Log("quizData.quizDataBuf[" + i + ", 2])�F" + quizData.quizDataBuf[i, 2]);  //����2
            Debug.Log("quizData.quizDataBuf[" + i + ", 3])�F" + quizData.quizDataBuf[i, 3]);  //����3
            Debug.Log("quizData.quizDataBuf[" + i + ", 4])�F" + quizData.quizDataBuf[i, 4]);  //����4
        }
    }

    void DispClearPanelSend()
    {
        //�N���A�p�l���Ƀ��b�Z�[�W�𑗐M����
        clearCanvas.SendMessage("DispClearPanel");

    }

    void STARTObjectDisp()
    {
        Vector3 newPos = this.transform.position;

        newPos.x = 6;
        newPos.y = 1;
        newPos.z = -5; // ��O�ɕ\��

        GameObject newGameObject = Instantiate(STARTObject) as GameObject;
        newGameObject.transform.position = newPos;
    }

}
