namespace WebAPIJsonDataMaker.Models.GW0044.Request
{
    public class MpnShunoIrai
    {
        public ChannelJoho ChannelJoho { get; set; }
        public string seikyuJohoShokaiShoribi { get; set; }
        public HosutoShoriTsubanJoho[] HosutoShoriTsubanJoho { get; set; }
        public HishimukeCenterCode HishimukeCenterCode { get; set; }
        public int shiharaiKeitai { get; set; }
        public string riyoshameiKana { get; set; }
        public string riyoshameiKanji { get; set; }
        public string shunokikanmeiKana { get; set; }
        public string shunokikanmeiKanji { get; set; }
        public string shunobi { get; set; }
        public string shokaiJikoku { get; set; }
        public string keshikomiKigenNengappi { get; set; }
        public string minkanOkyakusamaBango { get; set; }
        public string minkanKakuninBango { get; set; }
        public MinkanSeikyuJoho MinkanSeikyuJoho { get; set; }
        public string chikotaiNohuBango { get; set; }
        public string chikotaiKakuninBango { get; set; }
        public string chikotaiNohuKubun { get; set; }
        public ChikotaiNohuJoho ChikotaiNohuJoho { get; set; }
        public string chikotaiNiniJoho { get; set; }
        public string kokkokinNohuBango { get; set; }
        public string kokkokinKakuninBango { get; set; }
        public string kokkokinNohuKubun { get; set; }
        public KokkokinNohuJoho KokkokinNohuJoho { get; set; }
        public ShukkinKoza ShukkinKoza { get; set; }
        public KensaKomoku KensaKomoku { get; set; }
        public int saishuShunoIraiFlag { get; set; }

        public MpnShunoIrai()
        {

            const int MaxItemCount = 2;

            ChannelJoho = new ChannelJoho();
            HishimukeCenterCode = new HishimukeCenterCode();
            MinkanSeikyuJoho = new MinkanSeikyuJoho();
            ChikotaiNohuJoho = new ChikotaiNohuJoho();
            KokkokinNohuJoho = new KokkokinNohuJoho();
            ShukkinKoza = new ShukkinKoza();
            KensaKomoku = new KensaKomoku();

            HosutoShoriTsubanJoho = new HosutoShoriTsubanJoho[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                HosutoShoriTsubanJoho[count] = new HosutoShoriTsubanJoho();
            }
        }
    }
}