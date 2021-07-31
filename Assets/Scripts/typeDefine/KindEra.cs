using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct KindEra
{
    public int Jomon;           // “ê•¶E–í¶EŒÃ•­‘ã
    public int Asuka;           // ”ò’¹‘ã
    public int Nara;            // “Ş—Ç‘ã
    public int Heian;           // •½ˆÀ‘ã
    public int Kamakura;        // Š™‘q‘ã
    public int Muromati;        // º’¬‘ã
    public int Aduttimomoyama;  // ˆÀ“y“R‘ã
    public int Edo;             // ]ŒË‘ã
    public int Meiji;           // –¾¡
    public int Taisho;          // ‘å³
    public int Showa;           // º˜a
    public int Heisei;          // •½¬
    public int Kindai;          // ‚»‚Ì‘¼‹ß‘ã

    public KindEra(int Jo,int As,int Na, int Hea, int Ka, int Mu, int Ad,int Ed,int Me,int Ta,int Sh ,int Hes,int Ki)
    {
        this.Jomon = Jo;
        this.Asuka = As;
        this.Nara = Na;
        this.Heian = Hea;
        this.Kamakura = Ka;
        this.Muromati = Mu;
        this.Aduttimomoyama = Ad;
        this.Edo = Ed;
        this.Meiji = Me;
        this.Taisho = Ta;
        this.Showa = Sh;
        this.Heisei = Hes;
        this.Kindai = Ki;
    }



    //true‚¾‚Á‚½‚çnull‚¶‚á‚È‚¢
    public bool KindEraNullChechk()
    {
        int SumAll;

        SumAll = this.Jomon
                + this.Asuka
                + this.Nara
                + this.Heian
                + this.Kamakura
                + this.Muromati
                + this.Aduttimomoyama
                + this.Edo
                + this.Meiji
                + this.Taisho
                + this.Showa
                + this.Heisei
                + this.Kindai;

        return (SumAll != 0);
    }

}
