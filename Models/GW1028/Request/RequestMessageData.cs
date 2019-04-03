namespace WebAPIJsonDataMaker.Models.GW1028.Request 
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public BizIbYoyakuTorikeshi BizIbYoyakuTorikeshi;
    }
}