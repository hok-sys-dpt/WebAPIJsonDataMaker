namespace BankVision.WebAPI.Models.GW0043.Response
{
    public class MpnSeikyujohoShokai
    {
        public string shoribi;
        public string shoriJikoku;
        public HosutoShoriTsubanJoho[] HosutoShoriTsubanJoho;
        public KyotsuJoho KyotsuJoho;
        public int minkanSeikyuJohosu;
        public MinkanSeikyuJoho[] MinkanSeikyuJoho;
        public int minkanRenraku1HyojiKubun;
        public string minkanRenrakuJiko1Kana;
        public string minkanRenrakuJiko1Kanji;
        public int minkanRenraku2HyojiKubun;
        public string minkanRenrakuJiko2Kana;
        public string minkanRenrakuJiko2Kanji;
        public int chikotaiNohuJohosu;
        public ChikotaiNohuJoho[] ChikotaiNohuJoho;
        public int chikotaiRenraku1HyojiKubun;
        public string chikotaiRenrakuJiko1Kana;
        public string chikotaiRenrakuJiko1Kanji;
        public int chikotaiRenraku2HyojiKubun;
        public string chikotaiRenrakuJiko2Kana;
        public string chikotaiRenrakuJiko2Kanji;
        public KokkokinNohuJoho KokkokinNohuJoho;
        public ShukkinKoza ShukkinKoza;

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