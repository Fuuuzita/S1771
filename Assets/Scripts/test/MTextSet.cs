using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTextSet : MonoBehaviour
{
    public GameObject gameobject;
    public string strDisp;
    // Start is called before the first frame update
    void Start()
    {
        gameobject.GetComponent<TextMesh>().text = strDisp;
    }

    public void setTextSingle(string strSettext)
    {
        GetComponent<TextMesh>().text = strSettext;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
