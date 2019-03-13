using WebAPIJsonDataMaker.Models.GW0012.Request;
using WebAPIJsonDataMaker.Models.GW0008.Request;

namespace WebAPIJsonDataMaker.Models.Common
{
    public class RequestCsv
    {
        public GW0008RequestCsv GW0008RequestCsv { get; set; }
        public GW0012RequestCsv GW0012RequestCsv { get; set; }
    }
}