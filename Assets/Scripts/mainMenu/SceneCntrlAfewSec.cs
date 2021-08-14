using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // �V�[���؂�ւ��ɕK�v

public class SceneCntrlAfewSec : MonoBehaviour
{
    public string sceneName;  // �V�[�����FInspector�Ŏw��
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
    { // �^�b�`������ 
      // �V�[����؂芷����
        if (waitFlag)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

}
