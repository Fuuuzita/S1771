using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePanelConf : MonoBehaviour
{
    float vx;       // xの速さ
    float vy;       // yの速さ
    float posx;     // 位置x
    float posy;     // 位置y
    int pri;        // 表示優先度
    int num;        // 数字
    int col;        // 色
    float scale;	// スケール
    public string MainObjctName; //AnswerTouchEventを入れてるメインオブジェクト
    public GameObject MainObjctl;
    bool OnlyOnecetime = true;   //一度しかタッチできない
    bool touchFlg = false;       //タッチ検出用
    // Start is called before the first frame update
    void Start()
    {
        float speed = 0.5f; //そのうちコンフィグ化
        Debug.Log("MovePanelConf");
        // 速さ算出
        vx = (float)(Mathf.Cos(PanelData.GetspeedPatPosNowRad()) * speed);
        vy = (float)(Mathf.Sin(PanelData.GetspeedPatPosNowRad()) * speed);
         // 位置の算出
        posx = PanelData.GetspeedPatPosNowPosx();
        posy = PanelData.GetspeedPatPosNowPosy();
        num = PanelData.GetsnumPatStackNow();
        MainObjctl = GameObject.Find(MainObjctName);
        OnlyOnecetime = true;
        Debug.Log("vx: "+ vx);
        Debug.Log("vx: "+ vx + "  vy : " + vy);
        Debug.Log("sitei: " + PanelData.speedPatStack[PanelData.speed_numPatNowPos]);
        Debug.Log(PanelData.speed_numPatNowPos + "回");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(vx / 50, vy / 50, 0); // 水平移動する
        if (touchFlg)
        {
            if (OnlyOnecetime)
            {
                Debug.Log("クリックした瞬間");
                AnswerBuffer.answerBuffPush(num);
                MainObjctl.SendMessage("PanelTouchNotification");
                OnlyOnecetime = false;
            }
        }
    }

    public void TachtEvent_PushStacks()
    {
        Debug.Log("【TachtEvent_PushStacks】num:"+ num);
        touchFlg = true;
    }
}
 