namespace BankVision.WebAPI.Models.GW1015.Request
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    using BankVision.WebAPI.Models.Common;

    public class RequestMessageData : IWisRequestSystemInfo
    {
        public WisRequestSystemInfo WisRequestSystemInfo { get; set; }
        public SenyotozakashikoshiKaishuYoyaku SenyotozakashikoshiKaishuYoyaku;

        public RequestMessageData Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(RequestMessageData));
                serializer.Serialize(stream, this);
                stream.Position = 0L;
                XmlDocument doc = new XmlDocument();
                doc.PreserveWhitespace = true;
                doc.Load(stream);
                XmlNodeReader nodeReader = new XmlNodeReader(doc.DocumentElement);
                return (RequestMessageData)serializer.Deserialize(nodeReader);
            }
        }
    }
}