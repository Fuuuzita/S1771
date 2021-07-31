using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingKindSave : MonoBehaviour
{
    public GameObject Jomon;
    public GameObject Asuka;
    public GameObject Nara;
    public GameObject Heian;
    public GameObject Kamakura;
    public GameObject Muromati;
    public GameObject Aduttimomoyama;
    public GameObject Edo;
    public GameObject Meiji;
    public GameObject Taisho;
    public GameObject Showa;
    public GameObject Heisei;
    public GameObject Kindai;

    // Start is called before the first frame update
    void Start()
    {
        KindEra kindEra = new KindEra();
        kindEra = quizData.GetKindEra();

        Jomon.GetComponent<Toggle>().isOn = (kindEra.Jomon == 1);
        Asuka.GetComponent<Toggle>().isOn = (kindEra.Asuka == 1);
        Nara.GetComponent<Toggle>().isOn = (kindEra.Nara == 1);
        Heian.GetComponent<Toggle>().isOn = (kindEra.Heian == 1);
        Kamakura.GetComponent<Toggle>().isOn = (kindEra.Kamakura == 1);
        Muromati.GetComponent<Toggle>().isOn = (kindEra.Muromati == 1);
        Aduttimomoyama.GetComponent<Toggle>().isOn = (kindEra.Aduttimomoyama == 1);
        Edo.GetComponent<Toggle>().isOn = (kindEra.Edo == 1);
        Meiji.GetComponent<Toggle>().isOn = (kindEra.Meiji == 1);
        Taisho.GetComponent<Toggle>().isOn = (kindEra.Taisho == 1);
        Showa.GetComponent<Toggle>().isOn = (kindEra.Showa == 1);
        Heisei.GetComponent<Toggle>().isOn = (kindEra.Heisei == 1);
        Kindai.GetComponent<Toggle>().isOn = (kindEra.Kindai == 1);
        DispLogEra(kindEra);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveButtonDown()
    {
        KindEra kindEra = new KindEra();
        kindEra.Jomon = (Jomon.GetComponent<Toggle>().isOn ? 1 : 0);
        kindEra.Asuka = (Asuka.GetComponent<Toggle>().isOn ? 1 : 0);
        kindEra.Nara = (Nara.GetComponent<Toggle>().isOn ? 1 : 0);
        kindEra.Heian = (Heian.GetComponent<Toggle>().isOn ? 1 : 0);
        kindEra.Kamakura = (Kamakura.GetComponent<Toggle>().isOn ? 1 : 0);
        kindEra.Muromati = (Muromati.GetComponent<Toggle>().isOn ? 1 : 0);
        kindEra.Aduttimomoyama = (Aduttimomoyama.GetComponent<Toggle>().isOn ? 1 : 0);
        kindEra.Edo = (Edo.GetComponent<Toggle>().isOn ? 1 : 0);
        kindEra.Meiji = (Meiji.GetComponent<Toggle>().isOn ? 1 : 0);
        kindEra.Taisho = (Taisho.GetComponent<Toggle>().isOn ? 1 : 0);
        kindEra.Showa = (Showa.GetComponent<Toggle>().isOn ? 1 : 0);
        kindEra.Heisei = (Heisei.GetComponent<Toggle>().isOn ? 1 : 0);
        kindEra.Kindai = (Kindai.GetComponent<Toggle>().isOn ? 1 : 0);

        if(kindEra.KindEraNullChechk())
        {
            PlayerPrefs.SetInt("Jomon", kindEra.Jomon);
            PlayerPrefs.SetInt("Asuka", kindEra.Asuka);
            PlayerPrefs.SetInt("Nara", kindEra.Nara);
            PlayerPrefs.SetInt("Heian", kindEra.Heian);
            PlayerPrefs.SetInt("Kamakura", kindEra.Kamakura);
            PlayerPrefs.SetInt("Muromati", kindEra.Muromati);
            PlayerPrefs.SetInt("Aduttimomoyama", kindEra.Aduttimomoyama);
            PlayerPrefs.SetInt("Edo", kindEra.Edo);
            PlayerPrefs.SetInt("Meiji", kindEra.Meiji);
            PlayerPrefs.SetInt("Taisho", kindEra.Taisho);
            PlayerPrefs.SetInt("Showa", kindEra.Showa);
            PlayerPrefs.SetInt("Heisei", kindEra.Heisei);
            PlayerPrefs.SetInt("Kindai", kindEra.Kindai);
            PlayerPrefs.Save();
        }

        //int Savedata;
        //if (Jomon.GetComponent<Toggle>().isOn)
        //{
        //    Savedata = 1;
        //}
        //else
        //{
        //    Savedata = 0;
        //}
        //PlayerPrefs.SetInt("Jomon", Savedata);

        //if (Asuka.GetComponent<Toggle>().isOn)
        //{
        //    Savedata = 1;
        //}
        //else
        //{
        //    Savedata = 0;
        //}
        //PlayerPrefs.SetInt("Asuka", Savedata);

        //if (Nara.GetComponent<Toggle>().isOn)
        //{
        //    Savedata = 1;
        //}
        //else
        //{
        //    Savedata = 0;
        //}
        //PlayerPrefs.SetInt("Nara", Savedata);

        //if (Heian.GetComponent<Toggle>().isOn)
        //{
        //    Savedata = 1;
        //}
        //else
        //{
        //    Savedata = 0;
        //}
        //PlayerPrefs.SetInt("Heian", Savedata);

        //if (Kamakura.GetComponent<Toggle>().isOn)
        //{
        //    Savedata = 1;
        //}
        //else
        //{
        //    Savedata = 0;
        //}
        //PlayerPrefs.SetInt("Kamakura", Savedata);

        //if (Muromati.GetComponent<Toggle>().isOn)
        //{
        //    Savedata = 1;
        //}
        //else
        //{
        //    Savedata = 0;
        //}
        //PlayerPrefs.SetInt("Muromati", Savedata);

        //if (Aduttimomoyama.GetComponent<Toggle>().isOn)
        //{
        //    Savedata = 1;
        //}
        //else
        //{
        //    Savedata = 0;
        //}
        //PlayerPrefs.SetInt("Aduttimomoyama", Savedata);

        //if (Edo.GetComponent<Toggle>().isOn)
        //{
        //    Savedata = 1;
        //}
        //else
        //{
        //    Savedata = 0;
        //}
        //PlayerPrefs.SetInt("Edo", Savedata);

        //if (Meiji.GetComponent<Toggle>().isOn)
        //{
        //    Savedata = 1;
        //}
        //else
        //{
        //    Savedata = 0;
        //}
        //PlayerPrefs.SetInt("Meiji", Savedata);

        //if (Taisho.GetComponent<Toggle>().isOn)
        //{
        //    Savedata = 1;
        //}
        //else
        //{
        //    Savedata = 0;
        //}
        //PlayerPrefs.SetInt("Taisho", Savedata);

        //if (Showa.GetComponent<Toggle>().isOn)
        //{
        //    Savedata = 1;
        //}
        //else
        //{
        //    Savedata = 0;
        //}
        //PlayerPrefs.SetInt("Showa", Savedata);

        //if (Heisei.GetComponent<Toggle>().isOn)
        //{
        //    Savedata = 1;
        //}
        //else
        //{
        //    Savedata = 0;
        //}
        //PlayerPrefs.SetInt("Heisei", Savedata);

        //if (Kindai.GetComponent<Toggle>().isOn)
        //{
        //    Savedata = 1;
        //}
        //else
        //{
        //    Savedata = 0;
        //}
        //PlayerPrefs.SetInt("Kindai", Savedata);
        //PlayerPrefs.Save();

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
