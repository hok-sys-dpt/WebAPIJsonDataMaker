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