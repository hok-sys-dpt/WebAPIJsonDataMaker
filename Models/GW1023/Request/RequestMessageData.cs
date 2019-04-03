namespace WebAPIJsonDataMaker.Models.GW1023.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public KoshabetsuGaikokukawasesobaShokai KoshabetsuGaikokukawasesobaShokai { get; set; }
    }
}