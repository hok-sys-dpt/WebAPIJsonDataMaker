﻿namespace BankVision.WebAPI.Models.GW1017.Response
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    using BankVision.WebAPI.Models.Common;

    public class ResponseMessageData : IWisResponseSystemInfo
    {
        public WisResponseSystemInfo WisResponseSystemInfo { get; set; }
        public SenyoTozakashikoshiRisokuKeisanshoShokai SenyoTozakashikoshiRisokuKeisanshoShokai;

        public ResponseMessageData()
        {
            WisResponseSystemInfo = new WisResponseSystemInfo();
            SenyoTozakashikoshiRisokuKeisanshoShokai = new SenyoTozakashikoshiRisokuKeisanshoShokai();
        }

        public ResponseMessageData Clone()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ResponseMessageData));
                serializer.Serialize(stream, this);
                stream.Position = 0L;
                XmlDocument doc = new XmlDocument();
                doc.PreserveWhitespace = true;
                doc.Load(stream);
                XmlNodeReader nodeReader = new XmlNodeReader(doc.DocumentElement);
                return (ResponseMessageData)serializer.Deserialize(nodeReader);
            }
        }
    }
}