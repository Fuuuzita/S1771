using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class AnsweCntrl : MonoBehaviour
{
    public Sprite AnsPanel0;
    public Sprite AnsPanel1;
    public Sprite AnsPanel2;
    public Sprite AnsPanel3;
    public Sprite AnsPanel4;
    public Sprite AnsPanel5;
    public Sprite AnsPanel6;
    public Sprite AnsPanel7;
    public Sprite AnsPanel8;
    public Sprite AnsPanel9;
    public Sprite AnsPanelNULL;
    private Sprite AnsPanel = null;
    private bool ChangeFlg = false;
    private bool OverFlg = false;
    private Sprite sprite1;
    private SpriteRenderer spRenderer;
    private int AnswerNum;      //こたえ
    public AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {
    }
     
    public void AnsweCntrlInit()
    {
        spRenderer = gameObject.GetComponent<SpriteRenderer>();
        spRenderer.sprite = AnsPanelNULL;
        ChangeFlg = false;
        OverFlg = false;
        AnswerNum = 0;
    }

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        //ChangeFlgが立っていたら設定
        if(ChangeFlg)
        {
            if(OverFlg)
            {
                AudioSource audio = GetComponent<AudioSource>();
                spRenderer.sprite = AnsPanel;
                OverFlg = false;
                AnsPanel = null;
                // 音（sound）を一度だけ（PlayOneShot）再生する
                audio.PlayOneShot(sound);
            }
            else
            {
                spRenderer.sprite = AnsPanelNULL;
            }
            ChangeFlg = false;
        }
    }

    public void AnswInit()
    {
        ChangeFlg = true;
        OverFlg = false;
    }

    public void AnswDisp(int answer)
    {
        AnswPanelSelect(answer);
        ChangeFlg = true;
        OverFlg = true;

        AnswerNum = answer;     //こたえ
    }

    void AnswPanelSelect(int answer)
    {
        switch(answer)
        {
            case 0:
                AnsPanel = AnsPanel0;
                break;
            case 1:
                AnsPanel = AnsPanel1;
                break;
            case 2:
                AnsPanel = AnsPanel2;
                break;
            case 3:
                AnsPanel = AnsPanel3;
                break;
            case 4:
                AnsPanel = AnsPanel4;
                break;
            case 5:
                AnsPanel = AnsPanel5;
                break;
            case 6:
                AnsPanel = AnsPanel6;
                break;
            case 7:
                AnsPanel = AnsPanel7;
                break;
            case 8:
                AnsPanel = AnsPanel8;
                break;
            case 9:
                AnsPanel = AnsPanel9;
                break;
            default:
                AnsPanel = AnsPanelNULL;
                break;
        }
    }

    //答え取得処理
    public int GetAnswerPanelNum()
    {
        return AnswerNum;
    }

}
