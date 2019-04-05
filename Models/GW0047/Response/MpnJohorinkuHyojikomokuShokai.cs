namespace WebAPIJsonDataMaker.Models.GW0047.Response
{
    public class MpnJohorinkuHyojikomokuShokai
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public ShunokikanCode ShunokikanCode { get; set; }
        public int shunokikanShubetsu { get; set; }
        public int haraikomisakiHyojiKubun { get; set; }
        public string shunokikanmeiKana { get; set; }
        public string shunokikanmeiKanji { get; set; }
        public int riyoshameiHyojiKubun { get; set; }
        public string riyoshameiKana { get; set; }
        public string riyoshameiKanji { get; set; }
        public string minkanOkyakusamaBango { get; set; }
        public string minkanKakuninBango { get; set; }
        public MinkanSeikyuJoho MinkanSeikyuJoho { get; set; }
        public string chikotaiNohuBango { get; set; }
        public string chikotaiKakuninBango { get; set; }
        public string chikotaiNohuKubun { get; set; }
        public ChikotaiNohuJoho ChikotaiNohuJoho { get; set; }
        public string kokkokinNohuBango { get; set; }
        public string kokkokinKakuninBango { get; set; }
        public string kokkokinNohuKubun { get; set; }
        public KokkokinNohuJoho KokkokinNohuJoho { get; set; }

        public MpnJohorinkuHyojikomokuShokai()
        {
            ShunokikanCode = new ShunokikanCode();
            MinkanSeikyuJoho = new MinkanSeikyuJoho();
            ChikotaiNohuJoho = new ChikotaiNohuJoho();
            KokkokinNohuJoho = new KokkokinNohuJoho();
        }
    }
}