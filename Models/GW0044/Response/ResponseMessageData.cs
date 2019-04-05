namespace WebAPIJsonDataMaker.Models.GW0044.Response
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    using WebAPIJsonDataMaker.Models.Common;

    public class ResponseMessageData
    {
        public WisResponseSystemInfo WisResponseSystemInfo { get; set; }
        public MpnShunoIrai MpnShunoIrai;

        public ResponseMessageData()
        {
            WisResponseSystemInfo = new WisResponseSystemInfo();
            MpnShunoIrai = new MpnShunoIrai();
        }

    }
}