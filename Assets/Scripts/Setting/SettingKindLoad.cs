using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingKindLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        KindEra kindEra = new KindEra();
        kindEra.Jomon = PlayerPrefs.GetInt("Jomon", 1);                     // “ê•¶E–í¶EŒÃ•­Žž‘ã
        kindEra.Asuka = PlayerPrefs.GetInt("Asuka", 1);                     // ”ò’¹Žž‘ã
        kindEra.Nara = PlayerPrefs.GetInt("Nara", 1);                       // “Þ—ÇŽž‘ã
        kindEra.Heian = PlayerPrefs.GetInt("Heian", 1);                     // •½ˆÀŽž‘ã
        kindEra.Kamakura = PlayerPrefs.GetInt("Kamakura", 1);               // Š™‘qŽž‘ã
        kindEra.Muromati = PlayerPrefs.GetInt("Muromati", 1);               // Žº’¬Žž‘ã
        kindEra.Aduttimomoyama = PlayerPrefs.GetInt("Aduttimomoyama", 1);   // ˆÀ“y“ŽRŽž‘ã
        kindEra.Edo = PlayerPrefs.GetInt("Edo", 1);                         // ]ŒËŽž‘ã
        kindEra.Meiji = PlayerPrefs.GetInt("Meiji", 1);                     // –¾Ž¡
        kindEra.Taisho = PlayerPrefs.GetInt("Taisho", 1);                   // ‘å³
        kindEra.Showa = PlayerPrefs.GetInt("Showa", 1);                     // º˜a
        kindEra.Heisei = PlayerPrefs.GetInt("Heisei", 1);                   // •½¬
        kindEra.Kindai = PlayerPrefs.GetInt("Kindai", 1);                   // ‚»‚Ì‘¼‹ß‘ã
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
