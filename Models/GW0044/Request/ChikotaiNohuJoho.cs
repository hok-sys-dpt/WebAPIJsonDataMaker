namespace WebAPIJsonDataMaker.Models.GW0044.Request
{
    public class ChikotaiNohuJoho
    {
        public string chikotaiNohuNaiyoKana { get; set; }
        public string chikotaiNohuNaiyoKanji { get; set; }
        public string chikotaiShikibetsuBango { get; set; }
        public long chikotaiHaraikomiGokeiKingaku { get; set; }
        public long chikotaiNohuGokeiKingaku { get; set; }
        public long chikotaiNohuKingaku { get; set; }
        public int chikotaiEntaikinHyojiKubun { get; set; }
        public int chikotaiEntaikin { get; set; }
        public int chikotaiTesuryoHutanKubun { get; set; }
        public long chikotaiRiyoshaHutanTesuryo { get; set; }
    }
}