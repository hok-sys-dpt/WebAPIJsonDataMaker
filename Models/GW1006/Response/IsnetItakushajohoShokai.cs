using System;
using System.Collections.Generic;

namespace WebAPIJsonDataMaker.Models.GW1006.Response
{
    public class IsnetItakushajohoShokai 
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public int keiyakushaId { get; set; }
        public int riyoshaId { get; set; }
        public KurikaeshiSeigyo KurikaeshiSeigyo { get; set; }
        public int otoKensu { get; set; }
        public ItakushaJoho[] ItakushaJoho { get; set; }

        public IsnetItakushajohoShokai ()
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