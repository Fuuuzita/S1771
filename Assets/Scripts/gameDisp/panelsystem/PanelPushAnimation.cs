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
        // ©•ª©g‚ğÁ‚·
        Destroy(this.gameObject);
    }
}
