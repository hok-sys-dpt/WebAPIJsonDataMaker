namespace WebAPIJsonDataMaker.Models.GW0044.Request
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public MpnShunoIrai MpnShunoIrai { get; set; }

    }
}