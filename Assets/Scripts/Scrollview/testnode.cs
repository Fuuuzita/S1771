using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testnode : MonoBehaviour
{
    public GameObject obj;
    public GameObject parentObj;
    public GameObject eraText;
    int kindEraYousoNum;
    int kindEraquizDataPoint;
    int nowPoint;
    // Start is called before the first frame update
    void Start()
    {
        ////test

        kindEraYousoNum = QuizViewData.GetKEYousoNum();
        kindEraquizDataPoint = QuizViewData.GetkEquizDataPoint();
        nowPoint = 0;
        eraText.GetComponent<Text>().text 
            = quizData.quizDataTable[kindEraquizDataPoint, quizData.quizDataTBLAnsEra];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if((nowPoint < kindEraYousoNum) && (-1 != kindEraquizDataPoint))
        {
            GameObject childQuiz;
            GameObject childAnswer;
            Text text1;
            Text text2;

            childQuiz = obj.transform.Find("quiz").gameObject;
            childAnswer = obj.transform.Find("answer").gameObject;

            text1 = childQuiz.GetComponent<Text>();
            text1.text = quizData.quizDataTable[nowPoint+ kindEraquizDataPoint, quizData.quizDataTBLPara];
            text2 = childAnswer.GetComponent<Text>();
            text2.text = quizData.quizDataTable[nowPoint + kindEraquizDataPoint, quizData.quizDataTBLAns1Para]
                + quizData.quizDataTable[nowPoint + kindEraquizDataPoint, quizData.quizDataTBLAns2Para]
                + quizData.quizDataTable[nowPoint + kindEraquizDataPoint, quizData.quizDataTBLAns3Para]
                + quizData.quizDataTable[nowPoint + kindEraquizDataPoint, quizData.quizDataTBLAns4Para];
            Instantiate(obj, parentObj.transform);

            nowPoint++;
        }
    }
}
