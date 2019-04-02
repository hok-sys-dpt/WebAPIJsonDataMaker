namespace BankVision.WebAPI.Models.GW1022.Response
{
    public class GaikokukawasesobaIchiranShokai
    {
        public string shoribi;
        public string shoriJikoku;
        public int keiyakushaId;
        public int otoKensu;
        public SobaJoho[] SobaJoho;

        public GaikokukawasesobaIchiranShokai()
        {
            const int MaxItemCount = 10;
            SobaJoho = new SobaJoho[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                SobaJoho[count] = new SobaJoho();
            }
        }
    }
}