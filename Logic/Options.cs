namespace WebAPIJsonDataMaker.Logic
{
    public class Options
    {
        [CommandLine.Option('a', "apino", Required = true, HelpText = "APINo GWxxxx")]
        public string apiNo { get; set; }
        [CommandLine.Option('i', "io", Required = true, HelpText = "Request/Response")]
        public string reqOrRes { get; set; }
    }
}