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
            int AnsPanel1;  //こたえ1
            int AnsPanel2;  //こたえ2
            int AnsPanel3;  //こたえ3
            int AnsPanel4;  //こたえ4
            int Answer1;     //解答1
            int Answer2;     //解答2
            int Answer3;     //解答3
            int Answer4;     //解答4
            string AnsPanelName;
            GameObject AnsPanelObjctl;

            //こたえと解答を取得して比較する
            //こたえを取得
            AnsPanelObjctl = GameObject.Find(AnsPanel1NAME);
            AnsPanel1 = AnsPanelObjctl.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            AnsPanelObjctl = GameObject.Find(AnsPanel2NAME);
            AnsPanel2 = AnsPanelObjctl.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            AnsPanelObjctl = GameObject.Find(AnsPanel3NAME);
            AnsPanel3 = AnsPanelObjctl.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            AnsPanelObjctl = GameObject.Find(AnsPanel4NAME);
            AnsPanel4 = AnsPanelObjctl.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            //解答を取得
            Answer1 = int.Parse(quizData.GetquizDataBuf(1));
            Answer2 = int.Parse(quizData.GetquizDataBuf(2));
            Answer3 = int.Parse(quizData.GetquizDataBuf(3));
            Answer4 = int.Parse(quizData.GetquizDataBuf(4));
            //チェック
            if((AnsPanel1 == Answer1)
            && (AnsPanel2 == Answer2)
            && (AnsPanel3 == Answer3)
            && (AnsPanel4 == Answer4)
            )
            {
                //正解を表示する処理
                Debug.Log("正解");
            }
            else
            {
                //間違いを表示する処理
                Debug.Log("不正解");
            }
            //チェックが終わったので、PanelとQuizとAnswerPanelに終わったことを伝える

            ChekNotifyFlg = false;
        }
    }

    //答えを確認する準備ができた通知
    public void CheckAnswerNotificatiopn()
    {
        ChekNotifyFlg = true;
    }

    //初期化処理
    public void CheckAnswerInit()
    {
        ChekNotifyFlg = false;
    }


}
