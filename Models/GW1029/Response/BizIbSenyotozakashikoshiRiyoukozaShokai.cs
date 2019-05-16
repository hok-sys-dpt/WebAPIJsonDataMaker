namespace WebAPIJsonDataMaker.Models.GW1029.Response
{
    public class BizIbSenyotozakashikoshiRiyoukozaShokai
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public int otoKensu { get; set; }
        public SenyoTozakashikoshiRiyoukozaJoho[] SenyoTozakashikoshiRiyoukozaJoho { get; set; }

        public BizIbSenyotozakashikoshiRiyoukozaShokai()
        {
            const int MaxItemCount = 100;
            SenyoTozakashikoshiRiyoukozaJoho = new SenyoTozakashikoshiRiyoukozaJoho[MaxItemCount];

            for (int count = 0; count < MaxItemCount; count++)
            {
                SenyoTozakashikoshiRiyoukozaJoho[count] = new SenyoTozakashikoshiRiyoukozaJoho();
            }
        }
    }
}