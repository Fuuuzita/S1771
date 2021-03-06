using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct KindEra
{
    public int Jomon;           // 縄文・弥生・古墳時代
    public int Asuka;           // 飛鳥時代
    public int Nara;            // 奈良時代
    public int Heian;           // 平安時代
    public int Kamakura;        // 鎌倉時代
    public int Muromati;        // 室町時代
    public int Aduttimomoyama;  // 安土桃山時代
    public int Edo;             // 江戸時代
    public int Meiji;           // 明治
    public int Taisho;          // 大正
    public int Showa;           // 昭和
    public int Heisei;          // 平成
    public int Kindai;          // その他近代

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



    //trueだったらnullじゃない
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
