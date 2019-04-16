namespace WebAPIJsonDataMaker.Models.GW0031.Response
{
    public class KingakuKaiso
    {
        public long kagenKingaku { get; set; }
        public long jogenKingaku { get; set; }
        public int otoKensuKikan { get; set; }
        public KikanKaiso[] KikanKaiso { get; set; }

        public KingakuKaiso()
        {
            const int MaxItemCount = 20;
            KikanKaiso = new KikanKaiso[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                KikanKaiso[count] = new KikanKaiso();
            }
        }
    }
}