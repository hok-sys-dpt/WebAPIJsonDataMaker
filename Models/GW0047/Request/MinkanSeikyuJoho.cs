namespace WebAPIJsonDataMaker.Models.GW0047.Request
{
    public class MinkanSeikyuJoho
    {
        public string minkanSeikyuNaiyoKana { get; set; }
        public string minkanSeikyuNaiyoKanji { get; set; }
        public string minkanSeikyuBango { get; set; }
        public long minkanSeikyuGokeiKingaku { get; set; }
        public long minkanSeikyuKingaku { get; set; }
        public int minkanShohizeigakuHyojiKubun { get; set; }
        public long minkanShohizeigaku { get; set; }
        public int minkanEntaikinHyojiKubun { get; set; }
        public int minkanEntaikin { get; set; }
        public int minkanTesuryoHutanKubun { get; set; }
    }
}