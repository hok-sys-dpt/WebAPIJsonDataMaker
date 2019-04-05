namespace WebAPIJsonDataMaker.Models.GW0011.Request
{
    using WebAPIJsonDataMaker.Models.Common;
    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public GaikokuYokinKinriShoukai GaikokuYokinKinriShoukai { get; set; }
    }
}