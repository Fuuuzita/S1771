using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerTouchEvent : MonoBehaviour
{
    public string AnsPanel1Name;
    public string AnsPanel2Name;
    public string AnsPanel3Name;
    public string AnsPanel4Name;
    GameObject AnsPanelObjctl;
    public string MainObjctName; //AnswerTouchEventを入れてるメインオブジェクト
    GameObject MainObjctl;

    bool NotifyFlag;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void AnswerTouchEventInit()
    {
        NotifyFlag = false;
    }

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        int PullNum;
        int answerNext;
        string AnsPanelName;

        if (NotifyFlag)
        {
            PullNum = AnswerBuffer.answerBuffPull();
            answerNext = AnswerBuffer.GetanswerNextSel();
            Debug.Log("AnswerTouchEvent>>FixedUpdate>>AN:" + answerNext + "  PN :" + PullNum);
            //取り出す値がもうない
            if ((-1 == PullNum)||(-1 == answerNext))
            {
                NotifyFlag = false;
            }
            else
            {
//                Debug.Log("AnswerTouchEvent>>FixedUpdate>>AN:" + answerNext + "  PN :" + PullNum);
                AnsPanelName = AnsPanelSel(answerNext);
                AnsPanelObjctl = GameObject.Find(AnsPanelName);
                AnsPanelObjctl.GetComponent<AnsweCntrl>().AnswDisp(PullNum);
                if(AnswerBuffer.NextanswerNextSel())
                {
                    //最後まできたので答え合わせ
                    MainObjctl = GameObject.Find(MainObjctName);
                    MainObjctl.SendMessage("CheckAnswerNotificatiopn");
                }
            }
        }
    }

    public void PanelTouchNotification()
    {
        Debug.Log("PanelTouchNotification");
        NotifyFlag = true;
    }

    string AnsPanelSel(int PullNum)
    {
        string AnsPanel = "";
        switch(PullNum)
        {
            case 0:
                AnsPanel = AnsPanel1Name;
                break;
            case 1:
                AnsPanel = AnsPanel2Name;
                break;
            case 2:
                AnsPanel = AnsPanel3Name;
                break;
            case 3:
                AnsPanel = AnsPanel4Name;
                break;
            default:
                AnsPanel = AnsPanel1Name;
                break;
        }

        return AnsPanel;
    }

}
