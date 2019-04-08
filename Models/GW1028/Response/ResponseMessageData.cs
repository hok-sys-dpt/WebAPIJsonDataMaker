namespace WebAPIJsonDataMaker.Models.GW1028.Response
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    using WebAPIJsonDataMaker.Models.Common;

    public class ResponseMessageData
    {
        public WisResponseSystemInfo WisResponseSystemInfo { get; set; }
        public BizIbYoyakuTorikeshi BizIbYoyakuTorikeshi { get; set; }

        public ResponseMessageData()
        {
            WisResponseSystemInfo = new WisResponseSystemInfo();
            BizIbYoyakuTorikeshi = new BizIbYoyakuTorikeshi();
        }
    }
}