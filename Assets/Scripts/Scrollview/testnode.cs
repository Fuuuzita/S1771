using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testnode : MonoBehaviour
{
    public GameObject obj;
    public GameObject parentObj; /* �e�v�f */

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obj, parentObj.transform);
        Instantiate(obj, parentObj.transform);
        Instantiate(obj, parentObj.transform);
        Instantiate(obj, parentObj.transform);
        Instantiate(obj, parentObj.transform);
        Instantiate(obj, parentObj.transform);
        Instantiate(obj, parentObj.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
