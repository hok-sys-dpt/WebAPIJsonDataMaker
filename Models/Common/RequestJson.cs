using WebAPIJsonDataMaker.Models.GW0012.Request;
using WebAPIJsonDataMaker.Models.GW0008.Request;
using WebAPIJsonDataMaker.Models.GW1001.Request;
using WebAPIJsonDataMaker.Models.GW1002.Request;

namespace WebAPIJsonDataMaker.Models.Common
{
    public class RequestJson
    {
        public GW0008RequestJson GW0008RequestJson { get; set; }
        public GW0012RequestJson GW0012RequestJson { get; set; }
        public GW1001RequestJson GW1001RequestJson { get; set; }
        public GW1002RequestJson GW1002RequestJson { get; set; }
    }
}