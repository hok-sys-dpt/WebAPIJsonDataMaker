namespace WebAPIJsonDataMaker.Models.GW1008.Response
{
    public class BizIbNyushukkinMeisaiShokai : IKurikaeshiSeigyo
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public long orgId { get; set; }
        public KurikaeshiSeigyo KurikaeshiSeigyo { get; set; }
        public NyushukkinMeisaiJoho[] NyushukkinMeisaiJoho;
        public int otoKensu { get; set; }

        public BizIbNyushukkinMeisaiShokai()
        {
            const int MaxItemCount = 25;
            KurikaeshiSeigyo = new KurikaeshiSeigyo();
            NyushukkinMeisaiJoho = new NyushukkinMeisaiJoho[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                NyushukkinMeisaiJoho[count] = new NyushukkinMeisaiJoho();
            }
        }
    }
}