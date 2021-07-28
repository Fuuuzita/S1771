using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowQuizCount : MonoBehaviour
{
	//正解数
	public static int value; // 共有するカウンターの値

	public int startCount = 0; // 正解数初期値

	void Start()
	{ // 最初に行う
	}

	void Update()
	{ // ずっと
	  // カウンターの値を表示する
		GetComponent<Text>().text = value.ToString();
	}

	public static void NextCount()
	{
		value++;
		Debug.Log("value  "+ value);
	}

	public static void ClearCount()
	{
		value = 0;
	}
}
