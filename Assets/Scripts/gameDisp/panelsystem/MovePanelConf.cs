using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePanelConf : MonoBehaviour
{
    float vx;       // x�̑���
    float vy;       // y�̑���
    float posx;     // �ʒux
    float posy;     // �ʒuy
    int pri;        // �\���D��x
    int num;        // ����
    int col;        // �F
    float scale;	// �X�P�[��
    public string MainObjctName; //AnswerTouchEvent�����Ă郁�C���I�u�W�F�N�g
    public GameObject MainObjctl;
    bool OnlyOnecetime = true;   //��x�����^�b�`�ł��Ȃ�
    bool touchFlg = false;       //�^�b�`���o�p
    // Start is called before the first frame update
    void Start()
    {
        float speed = 0.5f; //���̂����R���t�B�O��
        Debug.Log("MovePanelConf");
        // �����Z�o
        vx = (float)(Mathf.Cos(PanelData.GetspeedPatPosNowRad()) * speed);
        vy = (float)(Mathf.Sin(PanelData.GetspeedPatPosNowRad()) * speed);
         // �ʒu�̎Z�o
        posx = PanelData.GetspeedPatPosNowPosx();
        posy = PanelData.GetspeedPatPosNowPosy();
        num = PanelData.GetsnumPatStackNow();
        MainObjctl = GameObject.Find(MainObjctName);
        OnlyOnecetime = true;
        Debug.Log("vx: "+ vx);
        Debug.Log("vx: "+ vx + "  vy : " + vy);
        Debug.Log("sitei: " + PanelData.speedPatStack[PanelData.speed_numPatNowPos]);
        Debug.Log(PanelData.speed_numPatNowPos + "��");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(vx / 50, vy / 50, 0); // �����ړ�����
        if (touchFlg)
        {
            if (OnlyOnecetime)
            {
                Debug.Log("�N���b�N�����u��");
                AnswerBuffer.answerBuffPush(num);
                MainObjctl.SendMessage("PanelTouchNotification");
                OnlyOnecetime = false;
            }
        }
    }

    public void TachtEvent_PushStacks()
    {
        Debug.Log("�yTachtEvent_PushStacks�znum:"+ num);
        touchFlg = true;
    }
}
 