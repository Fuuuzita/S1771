using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quizMainCtr : MonoBehaviour
{
    public GameObject newPrefab0;
    public GameObject newPrefab1;
    public GameObject newPrefab2;
    public GameObject newPrefab3;
    public GameObject newPrefab4;
    public GameObject newPrefab5;
    public GameObject newPrefab6;
    public GameObject newPrefab7;
    public GameObject newPrefab8;
    public GameObject newPrefab9;
    public Text QuizText;
    // quiz�I���̃X�^�b�N
    static int[] StackChosenQuiz = new int[quizData.quizDataBufNum];
    // �p�l�������I���̃X�^�b�N
    static int[] StackChosenAns = new int[PanelData.speedPatTableNum];
    static int[] StackChosenPanel = new int[PanelData.speedPatTableNum];
    static int[] Stackrandom11num4Ans = new int[PanelData.speedPatTableNum];

    static int prefabDispCount = 1;
    static int prefabDispTimer = 0;


    // Start is called before the first frame update
    void Start()
    {
        //quizData������
        quizData.quizDataInit();

        //quizData�쐬�@�����ł͂Ȃ����Ƃ͂킩��
        quizData.quizDataMake();

        LogquizDataDisp();

        //PanelData������
        PanelData.PanelDataInit();

        //PanelData�쐬����
        PanelData.PanelDataMake();

        LogpanelDataDisp();

        MakePanelOne();

        AnswerBuffer.answerBuffInit();

        //QuizText�̕\��
        QuizText.text = quizData.GetquizDataBuf(0);

    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        //0.1�b���Ƃɏo������
        if (prefabDispCount < PanelData.speedPatTableNum)
        {
            if (prefabDispTimer == 10)
            {
                PanelData.NextspeedPatPos();
                MakePanelOne();
                prefabDispTimer = 0;
                prefabDispCount++;
            }
            else
            {
                prefabDispTimer++;
            }

        }
    }

    void MakePanelOne()
    {
        GameObject newPrefab;
        Vector3 newPos = this.transform.position;
        int PrefabNum;
        int ColorNum;

        Debug.Log("MakePanelOne()");
        PrefabNum = PanelData.GetsnumPatStackNow();
        newPrefab = PrefabSelect(PrefabNum);
        ColorNum = Random.Range(0, 6);

        newPos.x = PanelData.GetspeedPatPosNowPosx();
        newPos.y = PanelData.GetspeedPatPosNowPosy();
        newPos.z = -5; // ��O�ɕ\��
                       // �v���n�u�����
        Debug.Log("newPos.x" + newPos.x);
        Debug.Log("newPos.y" + newPos.y);
        GameObject newGameObject = Instantiate(newPrefab) as GameObject;
        newGameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        newGameObject.transform.position = newPos;
        newGameObject.GetComponent<Renderer>().material.color = ColorSelect(ColorNum);
    }

    //�v���n�u�̑I��
    GameObject PrefabSelect(int PrefabNum)
    {
        GameObject newPrefab = newPrefab0;

        switch(PrefabNum)
        {
            case 0:
                newPrefab = newPrefab0;
                break;
            case 1:
                newPrefab = newPrefab1;
                break;
            case 2:
                newPrefab = newPrefab2;
                break;
            case 3:
                newPrefab = newPrefab3;
                break;
            case 4:
                newPrefab = newPrefab4;
                break;
            case 5:
                newPrefab = newPrefab5;
                break;
            case 6:
                newPrefab = newPrefab6;
                break;
            case 7:
                newPrefab = newPrefab7;
                break;
            case 8:
                newPrefab = newPrefab8;
                break;
            case 9:
                newPrefab = newPrefab9;
                break;
            default:
                newPrefab = newPrefab0;
                break;
        }

        return newPrefab;
    }

    //�w�i�F�̑I��
    Color ColorSelect(int ColorNum)
    {
        Color retColor = Color.white;
        switch (ColorNum)
        {
            case 0:
                retColor = Color.white;
                break;
            case 1:
                retColor = Color.blue;
                break;
            case 2:
                retColor = Color.cyan;
                break;
            case 3:
                retColor = Color.green;
                break;
            case 4:
                retColor = Color.magenta;
                break;
            case 5:
                retColor = Color.red;
                break;
            case 6:
                retColor = Color.yellow;
                break;
            default:
                retColor = Color.white;
                break;
        }
        return retColor;
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

    void LogpanelDataDisp()
    {
        int i;                  //For loop
        for (i = 0; i < PanelData.speedPatTableNum; i++)
        {
            Debug.Log("PanelData.speedPatStack[" + i + "]�F" + PanelData.speedPatStack[i]);
        }
        for (i = 0; i < PanelData.speedPatTableNum; i++)
        {
            Debug.Log("PanelData.numPatStack[" + i + "]�F" + PanelData.numPatStack[i]);
        }
    }


    public void button_CLC()
    {
        Debug.Log("�{�^���������܂���");
    }

}
