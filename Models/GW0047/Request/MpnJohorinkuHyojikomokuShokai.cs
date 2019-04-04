namespace WebAPIJsonDataMaker.Models.GW0047.Request
{
    public class MpnJohorinkuHyojikomokuShokai
    {
        public HishimukeCenterCode HishimukeCenterCode { get; set; }
        public int shiharaiKeitai { get; set; }
        public string riyoshameiKana { get; set; }
        public string shunokikanmeiKana { get; set; }
        public string shunokikanmeiKanji { get; set; }
        public string shunobi { get; set; }
        public string shokaiJikoku { get; set; }
        public string keshikomiKigenNengappi { get; set; }
        public string minkanOkyakusamaBango { get; set; }
        public string minkanKakuninBango { get; set; }
        public int minkanSeikyuJohosu { get; set; }
        public MinkanSeikyuJoho MinkanSeikyuJoho { get; set; }
        public string chikotaiNohuBango { get; set; }
        public string chikotaiKakuninBango { get; set; }
        public string chikotaiNohuKubun { get; set; }
        public int chikotaiNohuJohosu { get; set; }
        public ChikotaiNohuJoho ChikotaiNohuJoho { get; set; }
        public string chikotaiNiniJoho { get; set; }
        public string kokkokinNohuBango { get; set; }
        public string kokkokinKakuninBango { get; set; }
        public string kokkokinNohuKubun { get; set; }
        public KokkokinNohuJoho KokkokinNohuJoho { get; set; }
        public KensaKomoku KensaKomoku { get; set; }
    }
}