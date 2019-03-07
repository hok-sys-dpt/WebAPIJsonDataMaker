namespace JsonDataMaker.Models.Common
{
    public class WisRequestSystemInfo
    {
        public string version;
        public string clientId;
        public string clientTraceId;
        public string transactionId;
        public int requestType;
        public string clientKey;

        public WisRequestSystemInfo()
        {
            version = "";
            clientId = "CB02";
            clientTraceId = "6b4f47a4-3e5d-4157-a8a8-a7400b877af9";
            transactionId = "";
            requestType = 0;
            clientKey = "E1234CC5-6789-0AB1-2345-67890AC1F23";
        }
    }
}