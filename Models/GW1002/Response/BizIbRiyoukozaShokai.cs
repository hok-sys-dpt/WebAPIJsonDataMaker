namespace WebAPIJsonDataMaker.Models.GW1002.Response
{
    public class BizIbRiyoukozaShokai : IKurikaeshiSeigyo
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public KurikaeshiSeigyo KurikaeshiSeigyo { get; set; }
        public int otoKensu { get; set; }
        public RiyoKozaJoho[] RiyoKozaJoho { get; set; }

        public BizIbRiyoukozaShokai()
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