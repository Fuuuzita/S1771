using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // シーン切り替えに必要

public class SceneCntrlAfewSec : MonoBehaviour
{
    public string sceneName;  // シーン名：Inspectorで指定
    int waitCount;
    bool waitFlag;

    // Start is called before the first frame update
    void Start()
    {
        waitCount = 0;
        waitFlag = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(waitCount < 60) //3sec?
        {
            waitCount++;
        }
        else
        {
            waitFlag = true;
        }
    }

    public void StartButtonDown()
    { // タッチしたら 
      // シーンを切り換える
        if (waitFlag)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

}
