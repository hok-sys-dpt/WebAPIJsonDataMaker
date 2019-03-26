using System;
using System.Collections.Generic;

namespace WebAPIJsonDataMaker.Models.GW1016.Response
{
    public class SenyotozakashikoshiTorihikiMeisaiShokai
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public int keiyakushaId { get; set; }
        public int riyoshaId { get; set; }
        public int otoKensu { get; set; }
        public TorihikiMeisai[] TorihikiMeisai { get; set; }
        public KurikaeshiSeigyo KurikaeshiSeigyo { get; set; }

        public SenyotozakashikoshiTorihikiMeisaiShokai()
        {
            const int MaxItemCount = 50;
            KurikaeshiSeigyo = new KurikaeshiSeigyo();
            TorihikiMeisai = new TorihikiMeisai[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                TorihikiMeisai[count] = new TorihikiMeisai();
            }
        }
    }
}