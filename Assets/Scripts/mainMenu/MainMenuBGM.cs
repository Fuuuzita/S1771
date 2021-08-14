using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBGM : MonoBehaviour
{
    static bool isDeleteTiming = false;
    // Start is called before the first frame update
    void Start()
    {
        if(isDeleteTiming)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this);
            isDeleteTiming = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //シーンがゲームメインである場合は削除する。
        string sceneName = SceneManager.GetActiveScene().name;
        if(sceneName.Equals("GameMain"))
        {
            Destroy(this.gameObject);
            isDeleteTiming = false;
        }
    }
}
