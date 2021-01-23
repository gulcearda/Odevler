using System;
using System.Collections.Generic;
using System.Text;


namespace Dictionary
{
    public class MyDictionary<TKey, TValue>
    {
        TKey[] anahtarlar;
        TValue[] degerler;

        public MyDictionary()
        {
            anahtarlar = new TKey[0];
            degerler = new TValue[0];

        }


        public void Add(TKey anahtar, TValue deger)
        {

            TKey[] tempAnahtar = anahtarlar;
            
            anahtarlar = new TKey[anahtarlar.Length + 1];

            for (int i = 0; i < tempAnahtar.Length; i++)
            {
                anahtarlar[i] = tempAnahtar[i];
            }

            anahtarlar[anahtarlar.Length - 1] = anahtar;

            TValue[] tempDegerler = degerler;


            degerler = new TValue[degerler.Length + 1];

            for (int i = 0; i < tempDegerler.Length; i++)
            {
                degerler[i] = tempDegerler[i];
            }

            degerler[degerler.Length - 1] = deger;



        }

       

    }
}
