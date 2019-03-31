namespace WebAPIJsonDataMaker.Models.GW0021.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public Hurikae Hurikae { get; set; }
    }
}