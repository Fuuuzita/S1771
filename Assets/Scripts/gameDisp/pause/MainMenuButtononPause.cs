using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtononPause : MonoBehaviour
{
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }
}
