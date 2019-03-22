using System.IO;
using System.Text;
using CsvHelper;
using WebAPIJsonDataMaker.Logic;
using WebAPIJsonDataMaker.Models.Common;

namespace WebAPIJsonDataMaker.Controller
{
    public class DataMakerController
    {
        public void newJsonData(string apino, string reqOrRes, string path1, string path2)
        {

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var reader = new StreamReader(path1, Encoding.GetEncoding("shift-jis"));
            var csv = new CsvReader(reader);

            switch (apino)
            {
                //Gw0008預金口座残高照会
                case "GW0008":
                    {
                        IGWLogic iGWLogic = new GW0008Logic();
                        newData(iGWLogic, csv, apino, reqOrRes);
                        break;
                    }
                //Gw0012外貨預金残高照会
                case "GW0012":
                    {
                        IGWLogic iGWLogic = new GW0012Logic();
                        newData(iGWLogic, csv, apino, reqOrRes);
                        break;
                    }
                //Gw0019振込先口座照会
                case "GW0019":
                    {
                        IGWLogic iGWLogic = new GW0019Logic();
                        newData(iGWLogic, csv, apino, reqOrRes);
                        break;
                    }
                //Gw0020振込実行
                case "GW0020":
                    {
                        IGWLogic iGWLogic = new GW0020Logic();
                        newData(iGWLogic, csv, apino, reqOrRes);
                        break;
                    }
                //Gw0057振込予約実行
                case "GW0057":
                    {
                        IGWLogic iGWLogic = new GW0057Logic();
                        newData(iGWLogic, csv, apino, reqOrRes);
                        break;
                    }
                //Gw1001法人IB契約者情報照会
                case "GW1001":
                    {
                        IGWLogic iGWLogic = new GW1001Logic();
                        newData(iGWLogic, csv, apino, reqOrRes);
                        break;
                    }
                //GW1002法人IB利用口座照会
                case "GW1002":
                    {
                        IGWLogic iGWLogic = new GW1002Logic();
                        if (reqOrRes == "Request")
                        {
                            newData(iGWLogic, csv, apino, reqOrRes);
                        }
                        else
                        {
                            var reader2 = new StreamReader(path2, Encoding.GetEncoding("shift-jis"));
                            var csv2 = new CsvReader(reader2);
                            newListData(iGWLogic, csv, csv2, apino, reqOrRes);
                        }
                        break;
                    }
                //GW1003法人IB利用者照会
                case "GW1003":
                    {
                        IGWLogic iGWLogic = new GW1003Logic();
                        if (reqOrRes == "Request")
                        {
                            newData(iGWLogic, csv, apino, reqOrRes);
                        }
                        else
                        {
                            var reader2 = new StreamReader(path2, Encoding.GetEncoding("shift-jis"));
                            var csv2 = new CsvReader(reader2);
                            newListData(iGWLogic, csv, csv2, apino, reqOrRes);
                        }
                        break;
                    }
                //GW1004総給振委託者情報照会
                case "GW1004":
                    {
                        IGWLogic iGWLogic = new GW1004Logic();
                        newData(iGWLogic, csv, apino, reqOrRes);
                        break;
                    }
                //GW1007地方税納入契約者情報照会
                case "GW1007":
                    {
                        IGWLogic iGWLogic = new GW1007Logic();
                        newData(iGWLogic, csv, apino, reqOrRes);
                        break;
                    }
                //GW1012専用当座貸越実行
                case "GW1012":
                    {
                        IGWLogic iGWLogic = new GW1012Logic();
                        newData(iGWLogic, csv, apino, reqOrRes);
                        break;
                    }
                //GW1019専用当座貸越借入内容照会
                case "GW1019":
                    {
                        IGWLogic iGWLogic = new GW1019Logic();
                        newData(iGWLogic, csv, apino, reqOrRes);
                        break;
                    }
                //GW1025IB振込振替状況照会
                case "GW1025":
                    {
                        IGWLogic iGWLogic = new GW1025Logic();
                        newData(iGWLogic, csv, apino, reqOrRes);
                        break;
                    }
            }
        }

        public void newData(IGWLogic iGWLogic, CsvReader csv, string apino, string reqOrRes)
        {
            if (reqOrRes == "Request")
            {
                var csvModel = iGWLogic.ReadCsvRequest(csv);
                foreach (RequestCsv data in csvModel)
                {
                    iGWLogic.NewRequestJson(data, apino);
                }
            }
            else
            {
                var csvModel = iGWLogic.ReadCsvResponse(csv);
                foreach (ResponseCsv data in csvModel)
                {
                    iGWLogic.NewResponseJson(data, apino);
                }
            }
        }

        public void newListData(IGWLogic iGWLogic, CsvReader csv, CsvReader csv2, string apino, string reqOrRes)
        {
            if (reqOrRes == "Request")
            {
                throw new InvalidDataException();
            }
            else
            {
                var csvModel = iGWLogic.ReadCsvResponse(csv, csv2);
                foreach (ResponseCsv data in csvModel)
                {
                    iGWLogic.NewResponseJson(data, apino);
                }
            }
        }
    }
}