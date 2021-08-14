using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class PanelData
{
    //��`�l
    //����p�^�[���e�[�u����
    public static readonly int speedPatTableNum = 11;

    //static�ϐ�
    //����p�^�[���X�^�b�N
    public static int[] speedPatStack = new int[speedPatTableNum];
    //�����p�^�[���X�^�b�N
    public static int[] numPatStack = new int[speedPatTableNum];
    //���ݓ���p�^�[��
    public static int speed_numPatNowPos = -1; //���������l-1���ƃo�O��\��������̂ŗv����
    //���ݐ����p�^�[��
    public static int numPatStackNowPos = 0;
    // �p�l�������I���̃X�^�b�N
    static int[] StackChosenAns = new int[speedPatTableNum];
    static int[] StackChosenPanel = new int[speedPatTableNum];
    static int[] Stackrandom11num4Ans = new int[speedPatTableNum];
    // 1��I�����̃p�l���폜�t���O
    static bool delPanelFlg = false;

    //�萔
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

    //���ݓ���E�����p�^�[���擾
    public static int GetspeedPatPos()
    {
        return speed_numPatNowPos;
    }

    //���ݐ����p�^�[���擾
    public static int GetnumPatStackNowPos()
    {
        return numPatStackNowPos;
    }

    //���ݓ���p�^�[���C���N�������g����
    public static void NextspeedPatPos()
    {
        speed_numPatNowPos++;

        if(speed_numPatNowPos >= speedPatTableNum)
        {
            speed_numPatNowPos = speedPatTableNum - 1;
        }
    }

    //���ݓ���p�^�[���N���A����
    public static void Clearspeed_numPatNowPos()
    {
        speed_numPatNowPos = -1;
    }

    //���ݓ���p�^�[��-�p�x�擾����
    public static float GetspeedPatPosNowRad()
    {
        return speedPatTable[speedPatStack[speed_numPatNowPos],0];
    }
    //���ݓ���p�^�[��-posx
    public static float GetspeedPatPosNowPosx()
    {
        return speedPatTable[speedPatStack[speed_numPatNowPos], 1];
    }
    //���ݓ���p�^�[��-posy
    public static float GetspeedPatPosNowPosy()
    {
        return speedPatTable[speedPatStack[speed_numPatNowPos], 2];
    }

    //���ݓ���p�^�[��-�p�x�擾����
    public static int GetsnumPatStackNow()
    {
        return numPatStack[speed_numPatNowPos];
    }

    //PanelData������
    public static void PanelDataInit()
    {
        int iLoop;   //Loop�ϐ�

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

    //PanelData�쐬����
    public static void PanelDataMake()
    {
        int i;                  //Loop�ϐ�
        int RandomDataPanel;    //����

        //�����̐������܂ސ�����11����
        for (i = 0; i < speedPatTableNum; i++)
        {
            if (i < 4)
            {
                StackChosenAns[i] = int.Parse(quizData.GetquizDataBuf(i + 1));
            }
            else
            {
                // 0�`9�̐���
                StackChosenAns[i] = Random.Range(0, 9);
            }
        }

        //0-PanelData.speedPatTableNum �̗������d���Ȃ��ݒ肷��
        while (-1 == Stackrandom11num4Ans[speedPatTableNum - 1])
        {
            //�������擾
            RandomDataPanel = Random.Range(0, speedPatTableNum);
            //�d���`�F�b�N
            for (i = 0; i < speedPatTableNum; i++)
            {
                if (Stackrandom11num4Ans[i] == -1)
                {
                    //���ݒ�f�[�^
                    Stackrandom11num4Ans[i] = RandomDataPanel;
                    break;
                }
                else if (Stackrandom11num4Ans[i] == RandomDataPanel)
                {
                    //����Ă���̂Ŏ擾������
                    break;
                }
            }
        }

        //�f�[�^�ڂ� �o���p�l���̐ݒ�
        for (i = 0; i < speedPatTableNum; i++)
        {
            numPatStack[i] = StackChosenAns[Stackrandom11num4Ans[i]];
        }

        while (-1 == speedPatStack[speedPatTableNum - 1])
        {
            //�������擾
            RandomDataPanel = Random.Range(0, speedPatTableNum);
            //�d���`�F�b�N
            for (i = 0; i < speedPatTableNum; i++)
            {
                if (speedPatStack[i] == -1)
                {
                    //���ݒ�f�[�^
                    speedPatStack[i] = RandomDataPanel;
                    break;
                }
                else if (speedPatStack[i] == RandomDataPanel)
                {
                    //����Ă���̂Ŏ擾������
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
