namespace WebAPIJsonDataMaker.Models.GW1029.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public BizIbSenyotozakashikoshiRiyoukozaShokai BizIbSenyotozakashikoshiRiyoukozaShokai { get; set; }
    }
}