using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class PanelData
{
    //定義値
    //動作パターンテーブル数
    public static readonly int speedPatTableNum = 11;

    //static変数
    //動作パターンスタック
    public static int[] speedPatStack = new int[speedPatTableNum];
    //数字パターンスタック
    public static int[] numPatStack = new int[speedPatTableNum];
    //現在動作パターン
    public static int speed_numPatNowPos = -1; //★★初期値-1だとバグる可能性があるので要検討
    //現在数字パターン
    public static int numPatStackNowPos = 0;
    // パネル数字選択のスタック
    static int[] StackChosenAns = new int[speedPatTableNum];
    static int[] StackChosenPanel = new int[speedPatTableNum];
    static int[] Stackrandom11num4Ans = new int[speedPatTableNum];
    // 1問終了時のパネル削除フラグ
    static bool delPanelFlg = false;

    //定数
    public static readonly float[,] speedPatTable =
    {
        //rad       positionx   positiony
        {(float)(3.14/4),       (float)(-4.00),   (float)(-1.05) },
        {(float)(3.14/8),       (float)(-4.75),   (float)(1.25) },
        {(float)(-3.14/6),      (float)(-4.75),   (float)(3.00) },
        {(float)(-3.14/4),      (float)(-4.00),   (float)(4.60) },
        {(float)(-3.14/3),      (float)(-2.00),   (float)(6.00) },
        {(float)(-3.14/2),      (float)(0.00),   (float)(6.00) },
        {(float)((-3.14*2)/3),  (float)(2.00),   (float)(6.00) },
        {(float)((-3.14*3)/4),  (float)(4.00),   (float)(4.60) },
        {(float)((-3.14*5)/6),  (float)(4.75),   (float)(3.00) },
        {(float)((3.14*7)/8),   (float)(4.75),   (float)(1.25) },
        {(float)((3.14*3)/4),   (float)(4.00),   (float)(-1.05) }

    };

    //現在動作・数字パターン取得
    public static int GetspeedPatPos()
    {
        return speed_numPatNowPos;
    }

    //現在数字パターン取得
    public static int GetnumPatStackNowPos()
    {
        return numPatStackNowPos;
    }

    //現在動作パターンインクリメント処理
    public static void NextspeedPatPos()
    {
        speed_numPatNowPos++;

        if(speed_numPatNowPos >= speedPatTableNum)
        {
            speed_numPatNowPos = speedPatTableNum - 1;
        }
    }

    //現在動作パターンクリア処理
    public static void Clearspeed_numPatNowPos()
    {
        speed_numPatNowPos = -1;
    }

    //現在動作パターン-角度取得処理
    public static float GetspeedPatPosNowRad()
    {
        return speedPatTable[speedPatStack[speed_numPatNowPos],0];
    }
    //現在動作パターン-posx
    public static float GetspeedPatPosNowPosx()
    {
        return speedPatTable[speedPatStack[speed_numPatNowPos], 1];
    }
    //現在動作パターン-posy
    public static float GetspeedPatPosNowPosy()
    {
        return speedPatTable[speedPatStack[speed_numPatNowPos], 2];
    }

    //現在動作パターン-角度取得処理
    public static int GetsnumPatStackNow()
    {
        return numPatStack[speed_numPatNowPos];
    }

    //PanelData初期化
    public static void PanelDataInit()
    {
        int iLoop;   //Loop変数

        for (iLoop = 0; iLoop < speedPatTableNum; iLoop++)
        {
            StackChosenPanel[iLoop] = -1;
            StackChosenAns[iLoop] = -1;
            Stackrandom11num4Ans[iLoop] = -1;
            speedPatStack[iLoop] = -1;
            numPatStack[iLoop] = -1;
        }
        speed_numPatNowPos = -1;

        delPanelFlg = false;
    }

    //PanelData作成処理
    public static void PanelDataMake()
    {
        int i;                  //Loop変数
        int RandomDataPanel;    //乱数

        //答えの数字を含む数字を11個生成
        for (i = 0; i < speedPatTableNum; i++)
        {
            if (i < 4)
            {
                StackChosenAns[i] = int.Parse(quizData.GetquizDataBuf(i + 1));
            }
            else
            {
                // 0～9の数字
                StackChosenAns[i] = Random.Range(0, 9);
            }
        }

        //0-PanelData.speedPatTableNum の乱数を重複なく設定する
        while (-1 == Stackrandom11num4Ans[speedPatTableNum - 1])
        {
            //乱数を取得
            RandomDataPanel = Random.Range(0, speedPatTableNum);
            //重複チェック
            for (i = 0; i < speedPatTableNum; i++)
            {
                if (Stackrandom11num4Ans[i] == -1)
                {
                    //未設定データ
                    Stackrandom11num4Ans[i] = RandomDataPanel;
                    break;
                }
                else if (Stackrandom11num4Ans[i] == RandomDataPanel)
                {
                    //被っているので取得し直し
                    break;
                }
            }
        }

        //データ移す 出すパネルの設定
        for (i = 0; i < speedPatTableNum; i++)
        {
            numPatStack[i] = StackChosenAns[Stackrandom11num4Ans[i]];
        }

        while (-1 == speedPatStack[speedPatTableNum - 1])
        {
            //乱数を取得
            RandomDataPanel = Random.Range(0, speedPatTableNum);
            //重複チェック
            for (i = 0; i < speedPatTableNum; i++)
            {
                if (speedPatStack[i] == -1)
                {
                    //未設定データ
                    speedPatStack[i] = RandomDataPanel;
                    break;
                }
                else if (speedPatStack[i] == RandomDataPanel)
                {
                    //被っているので取得し直し
                    break;
                }
            }
        }

    }

    public static void SetdelPanelFlg()
    {
        delPanelFlg = true;
    }

    public static bool GetdelPanelFlg()
    {
        return delPanelFlg;
    }

}
