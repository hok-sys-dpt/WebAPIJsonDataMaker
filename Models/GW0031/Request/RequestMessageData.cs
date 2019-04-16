namespace WebAPIJsonDataMaker.Models.GW0031.Request
{

    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public TeikiyokinKinriShokai TeikiyokinKinriShokai { get; set; }
    }
}