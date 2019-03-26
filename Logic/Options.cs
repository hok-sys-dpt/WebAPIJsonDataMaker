using System.Collections.Generic;
using CommandLine;

namespace WebAPIJsonDataMaker.Logic
{
    public class Options
    {
        [Value(0, MetaName = "apino")]
        public string apiNo { get; set; }

        [Value(1, MetaName = "RequestOrResponse")]
        public string reqOrRes { get; set; }

        [Value(2, MetaName = "file1Name")]
        public string file1Name { get; set; }
        
        [Value(3, MetaName = "file2Name")]
        public string file2Name { get; set; }
    }
}