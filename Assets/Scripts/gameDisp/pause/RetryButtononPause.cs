using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButtononPause : MonoBehaviour
{
    string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }
}
