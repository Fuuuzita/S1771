using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class QuizViewData
{
	static int kEYousoNum;		//選択した要素数
	static int kEquizDataPoint; //選択した配列位置
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
