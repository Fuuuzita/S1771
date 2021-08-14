using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // シーン切り替えに必要

public class StartButton : MonoBehaviour
{
	public string sceneName;  // シーン名：Inspectorで指定

	void Start()
	{
	}
	public void StartButtonDown()
	{ // タッチしたら 
	  // シーンを切り換える
		SceneManager.LoadScene(sceneName);
	}
}
