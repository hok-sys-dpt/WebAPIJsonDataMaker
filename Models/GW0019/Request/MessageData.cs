namespace WebAPIJsonDataMaker.Models.GW0019.Request
{
    using WebAPIJsonDataMaker.Models.Common;
    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public HurikomisakiKozaShokai HurikomisakiKozaShokai { get; set; }

    }
}