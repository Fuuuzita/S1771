using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMessage : MonoBehaviour
{
    public float speed = -5; // �X�s�[�h�FInspector�Ŏw��

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
    { // �����ƍs���i��莞�Ԃ��ƂɁj
        this.transform.Translate(speed / 50, 0, 0); // �����ړ�����
    }

    void DestroyStart()
    {
        // �������g������
        Destroy(this.gameObject);
    }
}
