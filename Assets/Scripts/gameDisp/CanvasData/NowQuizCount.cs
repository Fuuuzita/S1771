using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NowQuizCount : MonoBehaviour
{
	//����
	public static int value; // ���L����J�E���^�[�̒l

	public int startCount = 0; // ���𐔏����l

	void Start()
	{ // �ŏ��ɍs��
	}

	void Update()
	{ // ������
	  // �J�E���^�[�̒l��\������
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
