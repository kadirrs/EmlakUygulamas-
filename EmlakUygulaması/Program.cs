using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Progarm
{
    public class Emlak
    {
        public long Id;
        public Adres Adres;
        public double Fiyat;
        public string Konumu;
        public DateTime IlanTarihi;
        public Musteri Sahibi;
        public decimal mt2;

    }

    public class Konut : Emlak
    {
        public int OdaSayisi;
        public int BinaYasi;
        public string Cephe;
        public string Isıtma;

    }

    public class Ev : Konut
    {
        public int Kat;
        public int BinaKatSayisi;
    }

    public class Arsa : Emlak
    {
        public string ImarDurumu;
        public int Ada;
        public int Parsel;

    }

    public class Villa : Konut
    {
        public decimal BahceMt2;
        public bool HavuzVarMi;

    }

    public class IsYeri : Konut
    {

    }

    public class KiralikEv : Ev
    {
        public KiralıkEmlakBilgileri KiralikBilgiler;
        public int Aidat;
    }

    public class SatilikEv : Ev
    {

    }

    public class KiralikArsa : Arsa
    {
        public KiralıkEmlakBilgileri KiralikBilgiler;
        public ArsaAltyapi ArsaAltyapisi;

    }

    public class SatilikArsa : Arsa
    {
        public ArsaAltyapi ArsaAltyapisi;
        public bool KatKarsiligi;
        public bool KrediyeUygunMu;
    }

    public class KiralikVilla : Villa
    {
        public KiralıkEmlakBilgileri KiralikBilgiler;
        public bool GunlukMu;
        public int Aidat;

    }

    public class SatilikVilla : Villa
    {

    }

    public class KiralıkIsyeri : IsYeri
    {
        public KiralıkEmlakBilgileri KiralikBilgiler;
        

    }

    public class SatilikIsyeri : IsYeri
    {

    }

    public class KiralıkEmlakBilgileri
    {
        public decimal Deposito;
        public int KontratSüresi;
        public string Kefil;

    }

    public class Adres
    {
        public string Sehir;
        public string Ilce;
        public string Semt;
        public string Mahalle;
        public string Sokak;
        public int BinaNo;
        public int DaireNo;
    }

    public class Musteri
    {
        public string Adi;
        public string Soyadi;
        public int Telefon;
        public string EPosta;
    }

    public class  ArsaAltyapi 
    {
        public bool ElektrikVarMi;
        public bool SuVarMi;
        public bool DogalgazVarMi;
        public bool YoluAcikMi;
    }


}
