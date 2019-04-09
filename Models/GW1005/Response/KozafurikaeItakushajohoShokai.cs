using System;
using System.Collections.Generic;

namespace WebAPIJsonDataMaker.Models.GW1005.Response
{
    public class KozafurikaeItakushajohoShokai
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public KurikaeshiSeigyo KurikaeshiSeigyo { get; set; }
        public int otoKensu { get; set; }
        public ItakushaJoho[] ItakushaJoho { get; set; }

        public KozafurikaeItakushajohoShokai()
        {
            const int MaxItemCount = 30;
            KurikaeshiSeigyo = new KurikaeshiSeigyo();
            ItakushaJoho = new ItakushaJoho[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                ItakushaJoho[count] = new ItakushaJoho();
            }
        }
    }
}