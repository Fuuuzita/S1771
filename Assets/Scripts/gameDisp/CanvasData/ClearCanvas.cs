using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearCanvas : MonoBehaviour
{
    //�p�l����o�^����
    public GameObject panel;
    //���g���C�{�^��
    public GameObject retryButton;
    //���C�����j���[�{�^��
    public GameObject mainmenuButton;
    //�X�R�A
    public GameObject scoreText;
    public GameObject scoreMesText;


    // Start is called before the first frame update
    void Start()
    {
        //�p�l�����B��
        panel.SetActive(false);
        //���g���C�{�^�����B��
        retryButton.SetActive(false);
        //���C�����j���[�{�^�����B��
        mainmenuButton.SetActive(false);
        //�X�R�A
        scoreText.SetActive(false);
        scoreMesText.SetActive(false);
    }

    //�N���A�p�l����\��������
    void DispClearPanel()
    {
        //�p�l����\��������
        panel.SetActive(true);
        //���g���C�{�^�����B��
        retryButton.SetActive(true);
        //���C�����j���[�{�^�����B��
        mainmenuButton.SetActive(true);
        //�X�R�A
        scoreText.SetActive(true);
        scoreMesText.SetActive(true);

    }
}
