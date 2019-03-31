namespace WebAPIJsonDataMaker.Models.GW0026.Request
{
    using WebAPIJsonDataMaker.Models.Common;
    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public TeikiyokinYonyuMeisaishokai TeikiyokinYonyuMeisaishokai { get; set; }
    }
}