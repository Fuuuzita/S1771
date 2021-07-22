using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class AnswerBuffer
{
    //通知用バッファ
    static int[] answerBuff = new int[4];
    //次設定こたえ
    static int answerNextSel = 0;

    public static void answerBuffInit()
    {
        int i;
        for (i = 0; i<4; i++)
        {
            answerBuff[i] = -1;
        }

        answerNextSel = 0;
    }

    public static void answerBuffPush(int num)
    {
        if(answerBuff[4-1] == -1)
        {
            for(int i =0 ; i < 4 ; i++)
            {
                if(answerBuff[i] == -1)
                {
                    answerBuff[i] = num;
                    break;
                }
            }
        }

    }

    public static int answerBuffPull()
    {
        int retNum = -1;

        if (answerBuff[0] != -1)
        {
            retNum = answerBuff[0];

            answerBuff[0] = answerBuff[1];
            answerBuff[1] = answerBuff[2];
            answerBuff[2] = answerBuff[3];
            answerBuff[3] = -1;
        }

        return retNum;
    }

    public static int GetanswerNextSel()
    {
        return answerNextSel;
    }

    public static bool NextanswerNextSel()
    {
        bool isRet = false;

        if(answerNextSel >= 3)
        {
            //最後まできた場合
            answerNextSel = -1;
            isRet = true;
        }
        else if (answerNextSel == -1)
        {
            isRet = false;
        }
        else
        {
            answerNextSel++;
            isRet = false;
        }
        return isRet;
    }

}

