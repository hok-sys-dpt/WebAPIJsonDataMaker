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
            // WIP: 入力ファイルが１つのAPI
            // テーブルクラスを作成して振り分ける isOneFile的な
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var reader = new StreamReader (path1, Encoding.GetEncoding("shift-jis"));
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
                //Gw1001法人IB契約者情報照会
                case "GW1001":
                    {
                        IGWLogic iGWLogic = new GW1001Logic();
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
    }
}