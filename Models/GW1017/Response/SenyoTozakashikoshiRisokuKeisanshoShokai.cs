namespace WebAPIJsonDataMaker.Models.GW1017.Response
{
    public class SenyoTozakashikoshiRisokuKeisanshoShokai
    {
        public string shoribi { get; set; }
        public string shoriJikoku { get; set; }
        public int keiyakushaId { get; set; }
        public int riyoshaId { get; set; }
        public TorihikiJoho TorihikiJoho { get; set; }
        public RisokuJoho RisokuJoho { get; set; }
        public KozaJoho KozaJoho { get; set; }
    }
}