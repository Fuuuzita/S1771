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
        //AnsPanel初期化処理
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
            int AnsPanel1;  //こたえ1
            int AnsPanel2;  //こたえ2
            int AnsPanel3;  //こたえ3
            int AnsPanel4;  //こたえ4
            int Answer1;     //解答1
            int Answer2;     //解答2
            int Answer3;     //解答3
            int Answer4;     //解答4
            Vector3 newPos = this.transform.position;
            GameObject newGameObject;

            //こたえと解答を取得して比較する
            //こたえを取得
            AnsPanel1 = AnsPanelObjctl1.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            AnsPanel2 = AnsPanelObjctl2.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            AnsPanel3 = AnsPanelObjctl3.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            AnsPanel4 = AnsPanelObjctl4.GetComponent<AnsweCntrl>().GetAnswerPanelNum();
            //解答を取得
            Answer1 = int.Parse(quizData.GetquizDataBuf(1));
            Answer2 = int.Parse(quizData.GetquizDataBuf(2));
            Answer3 = int.Parse(quizData.GetquizDataBuf(3));
            Answer4 = int.Parse(quizData.GetquizDataBuf(4));

            newPos.x = 0;
            newPos.y = -3.5f;
            newPos.z = -5; // 手前に表示
            //チェック
            if ((AnsPanel1 == Answer1)
            && (AnsPanel2 == Answer2)
            && (AnsPanel3 == Answer3)
            && (AnsPanel4 == Answer4)
            )
            {
                //正解を表示する処理
                Debug.Log("正解");
                newGameObject = Instantiate(positive) as GameObject;
            }
            else
            {
                //間違いを表示する処理
                Debug.Log("不正解");
                newGameObject = Instantiate(negative) as GameObject;
            }
            newGameObject.transform.position = newPos;
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
