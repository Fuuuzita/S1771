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
        // ���isound�j����x�����iPlayOneShot�j�Đ�����
        audio.PlayOneShot(sound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
