namespace WebAPIJsonDataMaker.Models.GW1027.Response
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    using WebAPIJsonDataMaker.Models.Common;

    public class ResponseMessageData
    {
        public WisResponseSystemInfo WisResponseSystemInfo { get; set; }
        public BizIbMpnJokyoShokai BizIbMpnJokyoShokai { get; set; }
    }
}