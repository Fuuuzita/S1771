using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseButton : MonoBehaviour
{
    public Text textClearonPause;
    string clearText;
    public GameObject clearPanel;
    public GameObject mainMenuButton;
    public GameObject retryButton;
    // Start is called before the first frame update
    void Start()
    {
        clearPanel.SetActive(false);
        mainMenuButton.SetActive(false);
        retryButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pauseButtonPush()
    {
        if(Time.timeScale != 0)
        {
            clearPanel.SetActive(true);
            mainMenuButton.SetActive(true);
            retryButton.SetActive(true);
            clearText = textClearonPause.text;
            textClearonPause.text = "";
            Time.timeScale = 0;
        }
        else
        {
            clearPanel.SetActive(false);
            mainMenuButton.SetActive(false);
            retryButton.SetActive(false);
            textClearonPause.text = clearText;
            Time.timeScale = 1;
        }
    }

}
