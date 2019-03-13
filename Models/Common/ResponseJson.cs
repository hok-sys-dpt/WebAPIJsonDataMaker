using WebAPIJsonDataMaker.Models.GW0008.Response;
using WebAPIJsonDataMaker.Models.GW0012.Response;
using WebAPIJsonDataMaker.Models.GW1002.Response;

namespace WebAPIJsonDataMaker.Models.Common
{
    public class ResponseJson
    {
        public GW0008ResponseJson GW0008ResponseJson { get; set; }
        public GW0012ResponseJson GW0012ResponseJson { get; set; }
        public GW1002ResponseJson GW1002ResponseJson { get; set; }
    }
}