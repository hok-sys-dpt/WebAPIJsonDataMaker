namespace BankVision.WebAPI.Models.GW1022.Response
{
    using System;
    using System.IO;
    using System.Xml.Serialization;

    using BankVision.WebAPI.Models.Common;

    public class ResponseMessageData : IWisResponseSystemInfo
    {
        public WisResponseSystemInfo WisResponseSystemInfo { get; set; }
        public GaikokukawasesobaIchiranShokai GaikokukawasesobaIchiranShokai;

        public ResponseMessageData()
        {
            WisResponseSystemInfo = new WisResponseSystemInfo();
            GaikokukawasesobaIchiranShokai = new GaikokukawasesobaIchiranShokai();
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