using WebAPIJsonDataMaker.Models.Common;

namespace WebAPIJsonDataMaker.Models.GW0020.Request
{
    public class RequestMessageData: IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public HurikomiJikko HurikomiJikko { get; set; }
    }
}