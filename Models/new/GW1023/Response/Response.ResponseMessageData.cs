namespace BankVision.WebAPI.Models.GW1023.Response
{
    using System;
    using System.IO;
    using System.Xml.Serialization;

    using BankVision.WebAPI.Models.Common;

    public class ResponseMessageData : IWisResponseSystemInfo
    {
        public WisResponseSystemInfo WisResponseSystemInfo { get; set; }
        public KoshabetsuGaikokukawasesobaShokai KoshabetsuGaikokukawasesobaShokai;

        public ResponseMessageData()
        {
            WisResponseSystemInfo = new WisResponseSystemInfo();
            KoshabetsuGaikokukawasesobaShokai = new KoshabetsuGaikokukawasesobaShokai();
        }

        public ResponseMessageData Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ResponseMessageData));
                serializer.Serialize(stream, this);
                stream.Position = 0L;
                return (ResponseMessageData)serializer.Deserialize(stream);
            }
        }
    }
}