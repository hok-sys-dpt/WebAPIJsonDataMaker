namespace WebAPIJsonDataMaker.Models.GW0024.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public TeikiyokinTsuikaYonyu TeikiyokinTsuikaYonyu { get; set; }
    }
}