using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class QuizViewData
{
	static int kEYousoNum;		//�I�������v�f��
	static int kEquizDataPoint; //�I�������z��ʒu
	static bool kESetFlgkESetFlg = false;

	public static void InitkindEraQuizView()
    {
		kEYousoNum = -1;
		kEquizDataPoint = -1;
		kESetFlgkESetFlg = false;
	}

	public static void SetKEYousoNum(int YousoNum)
    {
		kEYousoNum = YousoNum;
		kESetFlgkESetFlg = true;
	}

	public static void SetkEquizDataPoint(int quizDataPoint)
	{
		kEquizDataPoint = quizDataPoint;
	}

	public static int GetKEYousoNum()
	{
		return kEYousoNum;
	}

	public static int GetkEquizDataPoint()
	{
		return kEquizDataPoint;
	}

	public static bool GetkESetFlgkESetFlg()
	{
		return kESetFlgkESetFlg;
	}
}
