using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMessage : MonoBehaviour
{
    public float speed = -5; // スピード：Inspectorで指定

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyStart", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    { // ずっと行う（一定時間ごとに）
        this.transform.Translate(speed / 50, 0, 0); // 水平移動する
    }

    void DestroyStart()
    {
        // 自分自身を消す
        Destroy(this.gameObject);
    }
}
