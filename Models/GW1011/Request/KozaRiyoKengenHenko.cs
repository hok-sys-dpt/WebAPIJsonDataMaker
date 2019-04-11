namespace WebAPIJsonDataMaker.Models.GW1011.Request
{
    public class KozaRiyoKengenHenko
    {
        public int keiyakushaId { get; set; }
        public int riyoshaId { get; set; }
        public int shoriKubun { get; set; }
        public int kakuninJikkoKubun { get; set; }
        public KoshinKoza[] KoshinKoza;

        public KozaRiyoKengenHenko()
        {
            const int MaxItemCount = 100;
            KoshinKoza = new KoshinKoza[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                KoshinKoza[count] = new KoshinKoza();
            }
        }
    }
}