namespace WebAPIJsonDataMaker.Models.GW1022.Response
{
    public class GaikokukawasesobaIchiranShokai
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public int keiyakushaId { get; set; }
        public int otoKensu { get; set; }
        public SobaJoho[] SobaJoho { get; set; }

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