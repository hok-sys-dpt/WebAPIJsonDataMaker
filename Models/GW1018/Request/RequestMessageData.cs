namespace WebAPIJsonDataMaker.Models.GW1018.Request
{
    using WebAPIJsonDataMaker.Models.Common;
    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public SenyotozakashikoshiYoyakuMeisaiShokai SenyotozakashikoshiYoyakuMeisaiShokai { get; set; }
    }
}