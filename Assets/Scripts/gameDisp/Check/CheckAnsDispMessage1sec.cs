using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnsDispMessage1sec : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Vanish", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Vanish()
    {
        // 自分自身を消す
        Destroy(this.gameObject);
    }
}
