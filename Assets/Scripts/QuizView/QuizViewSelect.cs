using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // �V�[���؂�ւ��ɕK�v

public class QuizViewSelect : MonoBehaviour
{
    public string sceneName;  // �V�[�����FInspector�Ŏw��

    // Start is called before the first frame update
    void Start()
    {
        QuizViewData.InitkindEraQuizView();
    }

    public void QuizViewSelectJomon()
    {
        //��d�Ƀ^�b�`�����ꍇ�̃P�A
        if(false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Jomon);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Jomon);
            NextScene();
        }
    }

    public void QuizViewSelectAsuka()
    {
        //��d�Ƀ^�b�`�����ꍇ�̃P�A
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Asuka);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Asuka);
            NextScene();
        }
    }

    public void QuizViewSelectNara()
    {
        //��d�Ƀ^�b�`�����ꍇ�̃P�A
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Nara);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Nara);
            NextScene();
        }
    }

    public void QuizViewSelectHeian()
    {
        //��d�Ƀ^�b�`�����ꍇ�̃P�A
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Heian);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Heian);
            NextScene();
        }
    }

    public void QuizViewSelectKamakura()
    {
        //��d�Ƀ^�b�`�����ꍇ�̃P�A
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Kamakura);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Kamakura);
            NextScene();
        }
    }

    public void QuizViewSelectMuromati()
    {
        //��d�Ƀ^�b�`�����ꍇ�̃P�A
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Muromati);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Muromati);
            NextScene();
        }
    }

    public void QuizViewSelectAduttimomoyama()
    {
        //��d�Ƀ^�b�`�����ꍇ�̃P�A
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Aduttimomoyama);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Aduttimomoyama);
            NextScene();
        }
    }

    public void QuizViewSelectEdo()
    {
        //��d�Ƀ^�b�`�����ꍇ�̃P�A
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Edo);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Edo);
            NextScene();
        }
    }

    public void QuizViewSelectMeiji()
    {
        //��d�Ƀ^�b�`�����ꍇ�̃P�A
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Meiji);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Meiji);
            NextScene();
        }
    }

    public void QuizViewSelectTaisho()
    {
        //��d�Ƀ^�b�`�����ꍇ�̃P�A
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Taisho);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Taisho);
            NextScene();
        }
    }

    public void QuizViewSelectShowa()
    {
        //��d�Ƀ^�b�`�����ꍇ�̃P�A
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Showa);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Showa);
            NextScene();
        }
    }

    public void QuizViewSelectHeisei()
    {
        //��d�Ƀ^�b�`�����ꍇ�̃P�A
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Heisei);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Heisei);
            NextScene();
        }
    }

    public void QuizViewSelectKindai()
    {
        //��d�Ƀ^�b�`�����ꍇ�̃P�A
        if (false == QuizViewData.GetkESetFlgkESetFlg())
        {
            QuizViewData.SetKEYousoNum(quizData.kindEraYousoNum.Kindai);
            QuizViewData.SetkEquizDataPoint(quizData.kindEraquizDataPoint.Kindai);
            NextScene();
        }
    }

    void NextScene()
    { // �^�b�`������ 
      // �V�[����؂芷����
        SceneManager.LoadScene(sceneName);
    }

}
