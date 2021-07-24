using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelControler : MonoBehaviour
{
    public GameObject newPrefab0;
    public GameObject newPrefab1;
    public GameObject newPrefab2;
    public GameObject newPrefab3;
    public GameObject newPrefab4;
    public GameObject newPrefab5;
    public GameObject newPrefab6;
    public GameObject newPrefab7;
    public GameObject newPrefab8;
    public GameObject newPrefab9;

    static int prefabDispCount = 0;
    static int prefabDispTimer = 0;


    // Start is called before the first frame update
    void Start()
    {
        //���̑I��

        //

    }

    public void PanelDataInit()
    {
        //PanelData������
        PanelData.PanelDataInit();

        //PanelData�쐬����
        PanelData.PanelDataMake();

        LogpanelDataDisp();

        prefabDispCount = 0;

        prefabDispTimer = 0;
    }

    void FixedUpdate()
    {
        //0.1�b���Ƃɏo������
        if (prefabDispCount < PanelData.speedPatTableNum)
        {
            if (prefabDispTimer == 10)
            {
                //����
                //MakePanelOne�̌��NextspeedPatPos
                //���s���ƁAMovePanelConf�Œl������Ȃ��Ȃ�̂�
                //�b��I��MakePanelOne�̑O��NextspeedPatPos��ݒ肵�Ă���B
                //�����ŕK�v�ȏ����擾���AMovePanelConf�ɓn���d�g�݂����ׂ��ł��邪
                //�߂�ǂ������̂Ő��݃o�O�������Ɋ܂܂���
                //����
                PanelData.NextspeedPatPos();
                MakePanelOne();
                prefabDispTimer = 0;
                prefabDispCount++;
            }
            else
            {
                prefabDispTimer++;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LogpanelDataDisp()
    {
        int i;                  //For loop
        for (i = 0; i < PanelData.speedPatTableNum; i++)
        {
            Debug.Log("PanelData.speedPatStack[" + i + "]�F" + PanelData.speedPatStack[i]);
        }
        for (i = 0; i < PanelData.speedPatTableNum; i++)
        {
            Debug.Log("PanelData.numPatStack[" + i + "]�F" + PanelData.numPatStack[i]);
        }
    }

    public void MakePanelOne()
    {
        GameObject newPrefab;
        Vector3 newPos = this.transform.position;
        int PrefabNum;
        int ColorNum;

        Debug.Log("MakePanelOne()");
        PrefabNum = PanelData.GetsnumPatStackNow();
        newPrefab = PrefabSelect(PrefabNum);
        ColorNum = Random.Range(0, 6);

        newPos.x = PanelData.GetspeedPatPosNowPosx();
        newPos.y = PanelData.GetspeedPatPosNowPosy();
        newPos.z = -5; // ��O�ɕ\��
                       // �v���n�u�����
        Debug.Log("newPos.x" + newPos.x);
        Debug.Log("newPos.y" + newPos.y);
        GameObject newGameObject = Instantiate(newPrefab) as GameObject;
        newGameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        newGameObject.transform.position = newPos;
        newGameObject.GetComponent<Renderer>().material.color = ColorSelect(ColorNum);
    }

    //�v���n�u�̑I��
    GameObject PrefabSelect(int PrefabNum)
    {
        GameObject newPrefab = newPrefab0;

        switch (PrefabNum)
        {
            case 0:
                newPrefab = newPrefab0;
                break;
            case 1:
                newPrefab = newPrefab1;
                break;
            case 2:
                newPrefab = newPrefab2;
                break;
            case 3:
                newPrefab = newPrefab3;
                break;
            case 4:
                newPrefab = newPrefab4;
                break;
            case 5:
                newPrefab = newPrefab5;
                break;
            case 6:
                newPrefab = newPrefab6;
                break;
            case 7:
                newPrefab = newPrefab7;
                break;
            case 8:
                newPrefab = newPrefab8;
                break;
            case 9:
                newPrefab = newPrefab9;
                break;
            default:
                newPrefab = newPrefab0;
                break;
        }

        return newPrefab;
    }

        //�w�i�F�̑I��
    Color ColorSelect(int ColorNum)
    {
        Color retColor = Color.white;
        switch (ColorNum)
        {
            case 0:
                retColor = Color.white;
                break;
            case 1:
                retColor = Color.blue;
                break;
            case 2:
                retColor = Color.cyan;
                break;
            case 3:
                retColor = Color.green;
                break;
            case 4:
                retColor = Color.magenta;
                break;
            case 5:
                retColor = Color.red;
                break;
            case 6:
                retColor = Color.yellow;
                break;
            default:
                retColor = Color.white;
                break;
        }
        return retColor;
    }

}
