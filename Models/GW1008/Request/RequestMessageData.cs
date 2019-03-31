namespace WebAPIJsonDataMaker.Models.GW1008.Request
{
    using WebAPIJsonDataMaker.Models.Common;
    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public BizIbNyushukkinMeisaiShokai BizIbNyushukkinMeisaiShokai { get; set; }
    }
}