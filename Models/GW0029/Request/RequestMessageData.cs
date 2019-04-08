namespace WebAPIJsonDataMaker.Models.GW0029.Request
{
    using System;
    using System.IO;
    using System.Xml.Serialization;

    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public Teikiyokinshiharai Teikiyokinshiharai { get; set; }

    }
}