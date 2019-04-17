namespace WebAPIJsonDataMaker.Models.GW1013.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public SenyotozakashikoshiIreiHensai SenyotozakashikoshiIreiHensai { get; set; }
    }
}