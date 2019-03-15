using System;
using System.Collections.Generic;

namespace WebAPIJsonDataMaker.Models.GW1002.Response
{
    public class IbRiyoukouzaShoukai
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public int taishoKubun { get; set; }
        public string tenmeiKanji { get; set; }
        public KurikaeshiSeigyo KurikaeshiSeigyo { get; set; }
        public RiyoKozaJoho[] RiyoKozaJoho { get; set; }

        public IbRiyoukouzaShoukai()
        {
            const int MaxItemCount = 50;
            KurikaeshiSeigyo = new KurikaeshiSeigyo();
            RiyoKozaJoho = new RiyoKozaJoho[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                RiyoKozaJoho[count] = new RiyoKozaJoho();
            }
        }
    }
}