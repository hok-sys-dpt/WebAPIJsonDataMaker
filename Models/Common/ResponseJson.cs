using WebAPIJsonDataMaker.Models.GW0008.Response;
using WebAPIJsonDataMaker.Models.GW0012.Response;
using WebAPIJsonDataMaker.Models.GW0020.Response;
using WebAPIJsonDataMaker.Models.GW1001.Response;

namespace WebAPIJsonDataMaker.Models.Common
{
    public class ResponseJson
    {
        public GW0008ResponseJson GW0008ResponseJson { get; set; }
        public GW0012ResponseJson GW0012ResponseJson { get; set; }
        public GW0020ResponseJson GW0020ResponseJson { get; set; }
        public GW1001ResponseJson GW1001ResponseJson { get; set; }
    }
}