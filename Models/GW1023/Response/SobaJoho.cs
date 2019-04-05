namespace WebAPIJsonDataMaker.Models.GW1023.Response
{
    public class SobaJoho
    {
        public string tsukaCode { get; set; }
        public string tekiyoKaishibi { get; set; }
        public string tekiyokaishiJikoku { get; set; }
        public decimal futsuTTS { get; set; }
        public decimal futsuTTB { get; set; }
        public decimal teikiTTS { get; set; }
        public decimal teikiTTB { get; set; }
        public decimal ttm { get; set; }
        public int hojoTsukaHyoji { get; set; }
        public int kanzanTsukaTani { get; set; }
        public int cancelSobaHyojiKubun { get; set; }
        public int suspendChuHyoji { get; set; }
    }
}