namespace WebAPIJsonDataMaker.Models.GW1017.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public SenyoTozakashikoshiRisokuKeisanshoShokai SenyoTozakashikoshiRisokuKeisanshoShokai { get; set; }
    }
}