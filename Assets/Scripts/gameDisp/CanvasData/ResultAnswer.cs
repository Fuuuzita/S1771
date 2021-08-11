using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultAnswer : MonoBehaviour
{
    public static string Answer = "";
    static bool AnsDispFlg = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Text>().text = Answer;
        if(AnsDispFlg)
        {
            Invoke("VanishAnswerInvoke", 2);
            AnsDispFlg = false;
        }
    }

    public static void DispAnswer()
    {
        Answer = quizData.GetNowAnswer() + "”N";
        AnsDispFlg = true;
    }

    void VanishAnswerInvoke()
    {
        Answer = "";
    }
}
