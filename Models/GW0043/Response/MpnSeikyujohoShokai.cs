namespace WebAPIJsonDataMaker.Models.GW0043.Response
{
    public class MpnSeikyujohoShokai
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public HosutoShoriTsubanJoho[] HosutoShoriTsubanJoho { get; set; }
        public KyotsuJoho KyotsuJoho { get; set; }
        public int minkanSeikyuJohosu { get; set; }
        public MinkanSeikyuJoho[] MinkanSeikyuJoho { get; set; }
        public int minkanRenraku1HyojiKubun { get; set; }
        public string minkanRenrakuJiko1Kana { get; set; }
        public string minkanRenrakuJiko1Kanji { get; set; }
        public int minkanRenraku2HyojiKubun { get; set; }
        public string minkanRenrakuJiko2Kana { get; set; }
        public string minkanRenrakuJiko2Kanji { get; set; }
        public int chikotaiNohuJohosu { get; set; }
        public ChikotaiNohuJoho[] ChikotaiNohuJoho { get; set; }
        public int chikotaiRenraku1HyojiKubun { get; set; }
        public string chikotaiRenrakuJiko1Kana { get; set; }
        public string chikotaiRenrakuJiko1Kanji { get; set; }
        public int chikotaiRenraku2HyojiKubun { get; set; }
        public string chikotaiRenrakuJiko2Kana { get; set; }
        public string chikotaiRenrakuJiko2Kanji { get; set; }
        public KokkokinNohuJoho KokkokinNohuJoho { get; set; }
        public ShukkinKoza ShukkinKoza { get; set; }

        public MpnSeikyujohoShokai()
        {
            const int MaxHTItemCount = 2;
            const int MaxMSItemCount = 3;
            const int MaxCNItemCount = 3;

            HosutoShoriTsubanJoho = new HosutoShoriTsubanJoho[MaxHTItemCount];
            KyotsuJoho = new KyotsuJoho();
            MinkanSeikyuJoho = new MinkanSeikyuJoho[MaxMSItemCount];
            ChikotaiNohuJoho = new ChikotaiNohuJoho[MaxCNItemCount];
            KokkokinNohuJoho = new KokkokinNohuJoho();
            ShukkinKoza = new ShukkinKoza();

            for (int count = 0; count < MaxHTItemCount; count++)
            {
                HosutoShoriTsubanJoho[count] = new HosutoShoriTsubanJoho();
            }

            for (int count = 0; count < MaxMSItemCount; count++)
            {
                MinkanSeikyuJoho[count] = new MinkanSeikyuJoho();
            }

            for (int count = 0; count < MaxCNItemCount; count++)
            {
                ChikotaiNohuJoho[count] = new ChikotaiNohuJoho();
            }
        }
    }
}