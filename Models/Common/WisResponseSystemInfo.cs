namespace WebAPIJsonDataMaker.Models.Common
{
    public class WisResponseSystemInfo
    {
        public string version;
        public string transactionId;
        public int result;
        public string resultCode;
        public string resultDetail;

        public WisResponseSystemInfo()
        {
            version = "";
            transactionId = "51-1_1goSKY002KjZ";
            result = 0;
            resultCode = "000000";
            resultDetail = null;
        }
    }
}