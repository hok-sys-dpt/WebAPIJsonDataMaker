using WebAPIJsonDataMaker.Models.GW0008.Request;
using WebAPIJsonDataMaker.Models.GW0012.Request;
using WebAPIJsonDataMaker.Models.GW0019.Request;
using WebAPIJsonDataMaker.Models.GW0020.Request;
using WebAPIJsonDataMaker.Models.GW0057.Request;
using WebAPIJsonDataMaker.Models.GW1001.Request;
using WebAPIJsonDataMaker.Models.GW1002.Request;

namespace WebAPIJsonDataMaker.Models.Common
{
    public class RequestCsv
    {
        public GW0008RequestCsv GW0008RequestCsv { get; set; }
        public GW0012RequestCsv GW0012RequestCsv { get; set; }
        public GW0019RequestCsv GW0019RequestCsv { get; set; }
        public GW0020RequestCsv GW0020RequestCsv { get; set; } 
        public GW0057RequestCsv GW0057RequestCsv { get; set; } 
        public GW1001RequestCsv GW1001RequestCsv { get; set; }
        public GW1002RequestCsv GW1002RequestCsv { get; set; }
    }
}