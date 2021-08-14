using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // シーン切り替えに必要

public class QuizViewSelect : MonoBehaviour
{
    public string sceneName;  // シーン名：Inspectorで指定

    // Start is called before the first frame update
    void Start()
    {
        QuizViewData.InitkindEraQuizView();
    }

    public void QuizViewSelectJomon()
    {
        //二重にタッチした場合のケア
        if(false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Jomon);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Jomon);
            NextScene();
        }
    }

    public void QuizViewSelectAsuka()
    {
        //二重にタッチした場合のケア
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Asuka);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Asuka);
            NextScene();
        }
    }

    public void QuizViewSelectNara()
    {
        //二重にタッチした場合のケア
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Nara);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Nara);
            NextScene();
        }
    }

    public void QuizViewSelectHeian()
    {
        //二重にタッチした場合のケア
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Heian);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Heian);
            NextScene();
        }
    }

    public void QuizViewSelectKamakura()
    {
        //二重にタッチした場合のケア
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Kamakura);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Kamakura);
            NextScene();
        }
    }

    public void QuizViewSelectMuromati()
    {
        //二重にタッチした場合のケア
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Muromati);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Muromati);
            NextScene();
        }
    }

    public void QuizViewSelectAduttimomoyama()
    {
        //二重にタッチした場合のケア
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Aduttimomoyama);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Aduttimomoyama);
            NextScene();
        }
    }

    public void QuizViewSelectEdo()
    {
        //二重にタッチした場合のケア
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Edo);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Edo);
            NextScene();
        }
    }

    public void QuizViewSelectMeiji()
    {
        //二重にタッチした場合のケア
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Meiji);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Meiji);
            NextScene();
        }
    }

    public void QuizViewSelectTaisho()
    {
        //二重にタッチした場合のケア
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Taisho);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Taisho);
            NextScene();
        }
    }

    public void QuizViewSelectShowa()
    {
        //二重にタッチした場合のケア
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Showa);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Showa);
            NextScene();
        }
    }

    public void QuizViewSelectHeisei()
    {
        //二重にタッチした場合のケア
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Heisei);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Heisei);
            NextScene();
        }
    }

    public void QuizViewSelectKindai()
    {
        //二重にタッチした場合のケア
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Kindai);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Kindai);
            NextScene();
        }
    }

    void NextScene()
    { // タッチしたら 
      // シーンを切り換える
        SceneManager.LoadScene(sceneName);
    }

}
