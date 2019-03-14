using WebAPIJsonDataMaker.Models.GW0008.Response;
using WebAPIJsonDataMaker.Models.GW0012.Response;
using WebAPIJsonDataMaker.Models.GW0020.Response;
using WebAPIJsonDataMaker.Models.GW1001.Response;

namespace WebAPIJsonDataMaker.Models.Common
{
    public class ResponseCsv
    {
        public GW0008ResponseCsv GW0008ResponseCsv { get; set; }
        public GW0012ResponseCsv GW0012ResponseCsv { get; set; }
        public GW0020ResponseCsv GW0020ResponseCsv { get; set; }
        public GW1001ResponseCsv GW1001ResponseCsv { get; set; }
    }
}