using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingKindLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        KindEra kindEra = new KindEra();
        kindEra = quizData.KindEraLoad();
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
