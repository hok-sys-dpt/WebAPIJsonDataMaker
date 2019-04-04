namespace WebAPIJsonDataMaker.Models.GW1011.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public KozaRiyoKengenHenko KozaRiyoKengenHenko { get; set; }
    }
}