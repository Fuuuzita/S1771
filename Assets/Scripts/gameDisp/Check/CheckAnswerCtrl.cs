using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswerCtrl : MonoBehaviour
{
    private bool ChekNotifyFlg = false;
    public string AnsPanel1NAME;
    public string AnsPanel2NAME;
    public string AnsPanel3NAME;
    public string AnsPanel4NAME;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        if (ChekNotifyFlg)
        {
            int AnsPanel1;  //������1
            int AnsPanel2;  //������2
            int AnsPanel3;  //������3
            int AnsPanel4;  //������4
            int Answer1;     //��1
            int Answer2;     //��2
            int Answer3;     //��3
            int Answer4;     //��4
            string AnsPanelName;
            GameObject AnsPanelObjctl;

            //�������Ɖ𓚂��擾���Ĕ�r����
            //���������擾
            AnsPanelObjctl = GameObject.Find(AnsPanel1NAME);
            AnsPanel1 = AnsPanelObjctl.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            AnsPanelObjctl = GameObject.Find(AnsPanel2NAME);
            AnsPanel2 = AnsPanelObjctl.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            AnsPanelObjctl = GameObject.Find(AnsPanel3NAME);
            AnsPanel3 = AnsPanelObjctl.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            AnsPanelObjctl = GameObject.Find(AnsPanel4NAME);
            AnsPanel4 = AnsPanelObjctl.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            //�𓚂��擾
            Answer1 = int.Parse(quizData.GetquizDataBuf(1));
            Answer2 = int.Parse(quizData.GetquizDataBuf(2));
            Answer3 = int.Parse(quizData.GetquizDataBuf(3));
            Answer4 = int.Parse(quizData.GetquizDataBuf(4));
            //�`�F�b�N
            if((AnsPanel1 == Answer1)
            && (AnsPanel2 == Answer2)
            && (AnsPanel3 == Answer3)
            && (AnsPanel4 == Answer4)
            )
            {
                //������\�����鏈��
                Debug.Log("����");
            }
            else
            {
                //�ԈႢ��\�����鏈��
                Debug.Log("�s����");
            }
            //�`�F�b�N���I������̂ŁAPanel��Quiz��AnswerPanel�ɏI��������Ƃ�`����

            ChekNotifyFlg = false;
        }
    }

    //�������m�F���鏀�����ł����ʒm
    public void CheckAnswerNotificatiopn()
    {
        ChekNotifyFlg = true;
    }

    //����������
    public void CheckAnswerInit()
    {
        ChekNotifyFlg = false;
    }


}
