namespace WebAPIJsonDataMaker.Models.GW0030.Request
{
    using System;
    using System.IO;
    using System.Xml.Serialization;

    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public Tsumitateteikiyokinshiharai Tsumitateteikiyokinshiharai { get; set; }
    }
}