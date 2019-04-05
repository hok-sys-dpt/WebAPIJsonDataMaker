namespace WebAPIJsonDataMaker.Models.GW1009.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public NyukinTsuchiJohoKoshin NyukinTsuchiJohoKoshin { get; set; }
    }
}