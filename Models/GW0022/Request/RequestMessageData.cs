namespace WebAPIJsonDataMaker.Models.GW0022.Request
{
    using System;
    using System.IO;
    using System.Xml.Serialization;

    using WebAPIJsonDataMaker.Models.Common;

    public class RequestMessageData
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public GaikaFurikae GaikaFurikae{ get; set; }
    }
}