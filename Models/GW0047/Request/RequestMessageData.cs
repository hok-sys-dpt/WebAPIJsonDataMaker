namespace WebAPIJsonDataMaker.Models.GW0047.Request
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public MpnJohorinkuHyojikomokuShokai MpnJohorinkuHyojikomokuShokai { get; set; }
    }
}