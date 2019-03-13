using WebAPIJsonDataMaker.Models.GW0012.Response;
using WebAPIJsonDataMaker.Models.GW0008.Response;


namespace WebAPIJsonDataMaker.Models.Common
{
    public class ResponseCsv
    {
        public GW0008ResponseCsv GW0008ResponseCsv { get; set; }
        public GW0012ResponseCsv GW0012ResponseCsv { get; set; }
    }
}