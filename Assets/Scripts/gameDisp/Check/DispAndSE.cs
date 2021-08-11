using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispAndSE : MonoBehaviour
{
    public AudioClip sound;
    // Start is called before the first frame update
    void Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        // 音（sound）を一度だけ（PlayOneShot）再生する
        audio.PlayOneShot(sound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
