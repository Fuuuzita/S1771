using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // �V�[���؂�ւ��ɕK�v

public class StartButton : MonoBehaviour
{
	public string sceneName;  // �V�[�����FInspector�Ŏw��

	void Start()
	{
	}
	public void StartButtonDown()
	{ // �^�b�`������ 
	  // �V�[����؂芷����
		SceneManager.LoadScene(sceneName);
	}
}
