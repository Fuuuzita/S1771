using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class test : MonoBehaviour
{
    public GameObject newPrefab; // ���v���n�u�FInspector�Ŏw��
                                 // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void makePrefab()
    {
 //       Vector3 newPos = new Vector3(1.0f, 2.0f, 3.0f); ;
        Vector3 newPos = this.transform.position;
        newPos.x = 0;
        newPos.y = 0;
        newPos.z = -5; // ��O�ɕ\��
                       // �v���n�u�����
        GameObject newGameObject = Instantiate(newPrefab) as GameObject;
        newGameObject.transform.position = newPos;
    }
}
