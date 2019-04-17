namespace WebAPIJsonDataMaker.Models.GW1013.Response
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    using WebAPIJsonDataMaker.Models.Common;

    public class ResponseMessageData
    {
        public WisResponseSystemInfo WisResponseSystemInfo { get; set; }
        public SenyotozakashikoshiIreiHensai SenyotozakashikoshiIreiHensai { get; set; }

        
    }
}