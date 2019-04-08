namespace WebAPIJsonDataMaker.Models.GW0022.Response
{
    using System;
    using System.IO;
    using System.Xml.Serialization;

    using WebAPIJsonDataMaker.Models.Common;

    public class ResponseMessageData
    {
        public WisResponseSystemInfo WisResponseSystemInfo { get; set; }
        public GaikaFurikae GaikaFurikae{ get; set; }

        
    }
}