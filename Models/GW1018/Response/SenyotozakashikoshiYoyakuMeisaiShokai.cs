namespace WebAPIJsonDataMaker.Models.GW1018.Response
{
    public class SenyotozakashikoshiYoyakuMeisaiShokai : IKurikaeshiSeigyo
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public KurikaeshiSeigyo KurikaeshiSeigyo { get; set; }
        public int otoKensu { get; set; }
        public YoyakuMeisai[] YoyakuMeisai { get; set; }

        public SenyotozakashikoshiYoyakuMeisaiShokai()
        {
            const int MaxItemCount = 50;
            KurikaeshiSeigyo = new KurikaeshiSeigyo();
            YoyakuMeisai = new YoyakuMeisai[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                YoyakuMeisai[count] = new YoyakuMeisai();
            }
        }
    }
}