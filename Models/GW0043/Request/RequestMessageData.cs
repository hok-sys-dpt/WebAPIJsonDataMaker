namespace WebAPIJsonDataMaker.Models.GW0043.Request
{
    using WebAPIJsonDataMaker.Models.Common;
    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public MpnSeikyujohoShokai MpnSeikyujohoShokai { get; set; }
    }
}