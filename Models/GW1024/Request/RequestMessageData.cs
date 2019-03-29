namespace WebAPIJsonDataMaker.Models.GW1024.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public BizIbTeikiJyokyoShokai BizIbTeikiJyokyoShokai { get; set; }
    }
}