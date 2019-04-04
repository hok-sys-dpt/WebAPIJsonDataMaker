namespace WebAPIJsonDataMaker.Models.GW1027.Request
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System.ComponentModel;
    using System.Globalization;
    using System.Text;

    using WebAPIJsonDataMaker.Models.Common;
    public class RequestMessageData
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public BizIbMpnJokyoShokai BizIbMpnJokyoShokai { get; set; }

    }
}