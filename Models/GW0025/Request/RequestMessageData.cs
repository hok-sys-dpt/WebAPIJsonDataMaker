namespace WebAPIJsonDataMaker.Models.GW0025.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public TsumitateTeikiyokinTsuikaYonyu TsumitateTeikiyokinTsuikaYonyu { get; set; }
    }
}