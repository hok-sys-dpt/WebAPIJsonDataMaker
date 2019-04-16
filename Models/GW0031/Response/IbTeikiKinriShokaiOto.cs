namespace WebAPIJsonDataMaker.Models.GW0031.Response
{
    public class IbTeikiKinriShokaiOto
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public int shohinKubun { get; set; }
        public int shohinUchiwake1 { get; set; }
        public int shohinUchiwake2 { get; set; }
        public int shohinUchiwake3 { get; set; }
        public string shohinMeisho { get; set; }
        public int otoKensuKingaku { get; set; }
        public KingakuKaiso[] KingakuKaiso { get; set; }

        public IbTeikiKinriShokaiOto()
        {
            const int MaxItemCount = 10;
            KingakuKaiso = new KingakuKaiso[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                KingakuKaiso[count] = new KingakuKaiso();
            }
        }
    }
}