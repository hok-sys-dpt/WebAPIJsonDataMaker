using WebAPIJsonDataMaker.Models.Common;

namespace WebAPIJsonDataMaker.Models.GW1004.Request
{
    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public SokyufuriItakushajohoShokai SokyufuriItakushajohoShokai { get; set; }
    }
}