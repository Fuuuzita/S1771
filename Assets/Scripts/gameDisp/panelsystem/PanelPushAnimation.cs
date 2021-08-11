using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelPushAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Vanish", 0.8f);
    }

    void Vanish()
    {
        // 自分自身を消す
        Destroy(this.gameObject);
    }
}
