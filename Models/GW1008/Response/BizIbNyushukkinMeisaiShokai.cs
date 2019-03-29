namespace WebAPIJsonDataMaker.Models.GW1008.Response
{
    public class BizIbNyushukkinMeisaiShokai : IKurikaeshiSeigyo
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public int keiyakushaId { get; set; }
        public int temban { get; set; }
        public int kamokuCode { get; set; }
        public int kozabango { get; set; }
        public KurikaeshiSeigyo KurikaeshiSeigyo { get; set; }
        public NyushukkinMeisaiJoho[] NyushukkinMeisaiJoho;

        public BizIbNyushukkinMeisaiShokai()
        {
            const int MaxItemCount = 30;
            KurikaeshiSeigyo = new KurikaeshiSeigyo();
            NyushukkinMeisaiJoho = new NyushukkinMeisaiJoho[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                NyushukkinMeisaiJoho[count] = new NyushukkinMeisaiJoho();
            }
        }
    }
}