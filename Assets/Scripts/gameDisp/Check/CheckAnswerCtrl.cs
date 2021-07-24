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
    public GameObject positive;
    public GameObject negative;
    private GameObject AnsPanelObjctl1;
    private GameObject AnsPanelObjctl2;
    private GameObject AnsPanelObjctl3;
    private GameObject AnsPanelObjctl4;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void CheckAnswerCtrlInit()
    {
        AnsPanelObjctl1 = GameObject.Find(AnsPanel1NAME);
        AnsPanelObjctl2 = GameObject.Find(AnsPanel2NAME);
        AnsPanelObjctl3 = GameObject.Find(AnsPanel3NAME);
        AnsPanelObjctl4 = GameObject.Find(AnsPanel4NAME);
        ChekNotifyFlg = false;
        //AnsPanel����������
        AnsPanelObjctl1.GetComponent<AnsweCntrl>().AnsweCntrlInit();
        AnsPanelObjctl2.GetComponent<AnsweCntrl>().AnsweCntrlInit();
        AnsPanelObjctl3.GetComponent<AnsweCntrl>().AnsweCntrlInit();
        AnsPanelObjctl4.GetComponent<AnsweCntrl>().AnsweCntrlInit();
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
            Vector3 newPos = this.transform.position;
            GameObject newGameObject;

            //�������Ɖ𓚂��擾���Ĕ�r����
            //���������擾
            AnsPanel1 = AnsPanelObjctl1.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            AnsPanel2 = AnsPanelObjctl2.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            AnsPanel3 = AnsPanelObjctl3.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            AnsPanel4 = AnsPanelObjctl4.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            //�𓚂��擾
            Answer1 = int.Parse(quizData.GetquizDataBuf(1));
            Answer2 = int.Parse(quizData.GetquizDataBuf(2));
            Answer3 = int.Parse(quizData.GetquizDataBuf(3));
            Answer4 = int.Parse(quizData.GetquizDataBuf(4));

            newPos.x = 0;
            newPos.y = -3.5f;
            newPos.z = -5; // ��O�ɕ\��
            //�`�F�b�N
            if ((AnsPanel1 == Answer1)
            && (AnsPanel2 == Answer2)
            && (AnsPanel3 == Answer3)
            && (AnsPanel4 == Answer4)
            )
            {
                //������\�����鏈��
                Debug.Log("����");
                newGameObject = Instantiate(positive) as GameObject;
            }
            else
            {
                //�ԈႢ��\�����鏈��
                Debug.Log("�s����");
                newGameObject = Instantiate(negative) as GameObject;
            }
            newGameObject.transform.position = newPos;
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
