namespace WebAPIJsonDataMaker.Models.GW1022.Request
{
    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public GaikokukawasesobaIchiranShokai GaikokukawasesobaIchiranShokai { get; set; }
    }
}