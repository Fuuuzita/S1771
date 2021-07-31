using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingKindLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        KindEra kindEra = new KindEra();
        kindEra.Jomon = PlayerPrefs.GetInt("Jomon", 1);                     // �ꕶ�E�퐶�E�Õ�����
        kindEra.Asuka = PlayerPrefs.GetInt("Asuka", 1);                     // �򒹎���
        kindEra.Nara = PlayerPrefs.GetInt("Nara", 1);                       // �ޗǎ���
        kindEra.Heian = PlayerPrefs.GetInt("Heian", 1);                     // ��������
        kindEra.Kamakura = PlayerPrefs.GetInt("Kamakura", 1);               // ���q����
        kindEra.Muromati = PlayerPrefs.GetInt("Muromati", 1);               // ��������
        kindEra.Aduttimomoyama = PlayerPrefs.GetInt("Aduttimomoyama", 1);   // ���y���R����
        kindEra.Edo = PlayerPrefs.GetInt("Edo", 1);                         // �]�ˎ���
        kindEra.Meiji = PlayerPrefs.GetInt("Meiji", 1);                     // ����
        kindEra.Taisho = PlayerPrefs.GetInt("Taisho", 1);                   // �吳
        kindEra.Showa = PlayerPrefs.GetInt("Showa", 1);                     // ���a
        kindEra.Heisei = PlayerPrefs.GetInt("Heisei", 1);                   // ����
        kindEra.Kindai = PlayerPrefs.GetInt("Kindai", 1);                   // ���̑��ߑ�
        quizData.SetKindEra(kindEra);
//        DispLogEra(kindEra);
        quizData.MakeUsequizDataTable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void DispLogEra(KindEra kindEra)
    {
        Debug.Log(">>>>>>>>>>>>>>>>>>>>");
        Debug.Log("kindEra.Jomon " + kindEra.Jomon);
        Debug.Log("kindEra.Asuka " + kindEra.Asuka);
        Debug.Log("kindEra.Nara " + kindEra.Nara);
        Debug.Log("kindEra.Heian " + kindEra.Heian);
        Debug.Log("kindEra.Kamakura " + kindEra.Kamakura);
        Debug.Log("kindEra.Muromati " + kindEra.Muromati);
        Debug.Log("kindEra.Aduttimomoyama " + kindEra.Aduttimomoyama);
        Debug.Log("kindEra.Edo " + kindEra.Edo);
        Debug.Log("kindEra.Meiji " + kindEra.Meiji);
        Debug.Log("kindEra.Taisho " + kindEra.Taisho);
        Debug.Log("kindEra.Showa " + kindEra.Showa);
        Debug.Log("kindEra.Heisei " + kindEra.Heisei);
        Debug.Log("kindEra.Kindai " + kindEra.Kindai);
        Debug.Log(">>>>>>>>>>>>>>>>>>>>");

    }
}
