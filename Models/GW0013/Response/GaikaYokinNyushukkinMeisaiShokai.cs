namespace WebAPIJsonDataMaker.Models.GW0013.Response
{
    public class GaikaYokinNyushukkinMeisaiShokai : IKurikaeshiSeigyo
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public KozaJoho KozaJoho { get; set; }
        public int shokaiDaikoShokaiHyoji { get; set; }
        public KurikaeshiSeigyo KurikaeshiSeigyo { get; set; }
        public int otoKensu { get; set; }
        public MeisaiJoho[] MeisaiJoho { get; set; }

        public GaikaYokinNyushukkinMeisaiShokai()
        {
            const int MaxItemCount = 20;
            KozaJoho = new KozaJoho();
            KurikaeshiSeigyo = new KurikaeshiSeigyo();
            MeisaiJoho = new MeisaiJoho[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                MeisaiJoho[count] = new MeisaiJoho();
            }
        }

    }
}