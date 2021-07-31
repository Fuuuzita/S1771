using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct KindEra
{
    public int Jomon;           // �ꕶ�E�퐶�E�Õ�����
    public int Asuka;           // �򒹎���
    public int Nara;            // �ޗǎ���
    public int Heian;           // ��������
    public int Kamakura;        // ���q����
    public int Muromati;        // ��������
    public int Aduttimomoyama;  // ���y���R����
    public int Edo;             // �]�ˎ���
    public int Meiji;           // ����
    public int Taisho;          // �吳
    public int Showa;           // ���a
    public int Heisei;          // ����
    public int Kindai;          // ���̑��ߑ�

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



    //true��������null����Ȃ�
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
