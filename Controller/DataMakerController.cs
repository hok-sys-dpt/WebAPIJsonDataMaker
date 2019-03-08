using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using JsondataMaker.Logic;
using JsondataMaker.Models.GW0008.Request;
using JsondataMaker.Models.GW0008.Response;
using JsondataMaker.Models.GW0012.Request;
using JsondataMaker.Models.GW0012.Response;
using Newtonsoft.Json;
using System.Text;

namespace JsondataMaker.Controller
{
    public class DataMakerController
    {
        public void newJsonData (string apino, string reqOrRes, string path1, string path2)
        {
            // WIP: 入力ファイルが１つのAPI
            // テーブルクラスを作成して振り分ける isOneFile的な
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var reader = new StreamReader (path1, Encoding.GetEncoding("shift-jis"));
            var csv = new CsvReader (reader);
            switch (apino)
            {
                //Gw0008預金口座残高照会
                case "GW0008":
                    var gw0008logic = new GW0008Logic ();
                    if (reqOrRes == "Request")
                    {
                        var gw0008data = gw0008logic.ReadCsvRequest (csv);
                        foreach (GW0008RequestCsv data in gw0008data)
                        {
                            var outputData = gw0008logic.NewRequestJson (data);
                            var jf = new JsonFileWriter ();
                            jf.New (outputData.RequestMessageData, outputData.FileNo, apino, reqOrRes);
                        }
                    }
                    else
                    {
                        var gw0008data = gw0008logic.ReadCsvResponse (csv);
                        foreach (GW0008ResponseCsv data in gw0008data)
                        {
                            var outputData = gw0008logic.NewResponseJson (data);
                            var jf = new JsonFileWriter ();
                            jf.New (outputData.ResponseMessageData, outputData.FileNo, apino, reqOrRes);
                        }
                    }
                    break;

                //Gw0012外貨預金残高照会
                case "GW0012":
                    var gw0012logic = new GW0012Logic ();
                    if (reqOrRes == "Request")
                    {
                        var gw0012data = gw0012logic.ReadCsvRequest (csv);
                        foreach (GW0012RequestCsv data in gw0012data)
                        {
                            var outputData = gw0012logic.NewRequestJson (data);
                            var jf = new JsonFileWriter ();
                            jf.New (outputData.RequestMessageData, outputData.FileNo, apino, reqOrRes);
                        }
                    }
                    else
                    {
                        var gw0012data = gw0012logic.ReadCsvResponse (csv);
                        foreach (GW0012ResponseCsv data in gw0012data)
                        {
                            var outputData = gw0012logic.NewResponseJson (data);
                            var jf = new JsonFileWriter ();
                            jf.New (outputData.ResponseMessageData, outputData.FileNo, apino, reqOrRes);
                        }
                    }
                    break;
            }
        }
    }
}