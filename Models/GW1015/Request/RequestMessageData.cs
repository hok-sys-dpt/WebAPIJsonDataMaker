namespace WebAPIJsonDataMaker.Models.GW1015.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public SenyotozakashikoshiKaishuYoyaku SenyotozakashikoshiKaishuYoyaku { get; set; }
    }
}