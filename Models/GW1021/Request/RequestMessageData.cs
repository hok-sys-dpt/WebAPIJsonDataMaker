namespace WebAPIJsonDataMaker.Models.GW1021.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public BizIbPasswordNinsho BizIbPasswordNinsho { get; set; }
    }
}