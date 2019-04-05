namespace WebAPIJsonDataMaker.Models.GW1014.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public SenyotozakashikoshiJikkoYoyaku SenyotozakashikoshiJikkoYoyaku { get; set; }
    }
}