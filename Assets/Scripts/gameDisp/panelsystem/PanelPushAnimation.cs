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
        // �������g������
        Destroy(this.gameObject);
    }
}
