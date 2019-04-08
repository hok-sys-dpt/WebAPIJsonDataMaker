namespace WebAPIJsonDataMaker.Models.GW0045.Response
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    using WebAPIJsonDataMaker.Models.Common;

    public class ResponseMessageData
    {
        public WisResponseSystemInfo WisResponseSystemInfo { get; set; }
        public MpnShunokikanYohiShokai MpnShunokikanYohiShokai;
    }
}