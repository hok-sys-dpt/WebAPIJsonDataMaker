namespace WebAPIJsonDataMaker.Models.GW1019.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public SenyoTozakashikoshiKariirenaiyoShokai SenyoTozakashikoshiKariirenaiyoShokai { get; set; }
    }
}