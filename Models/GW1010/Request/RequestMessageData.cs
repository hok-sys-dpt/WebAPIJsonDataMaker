namespace WebAPIJsonDataMaker.Models.GW1010.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public RiyoshaJohoHenko RiyoshaJohoHenko { get; set; }
    }
}