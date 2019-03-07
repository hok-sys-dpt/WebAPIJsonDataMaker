using System;
using System.IO;
using CsvHelper;
using Newtonsoft.Json;
using System.Collections.Generic;
using JsondataMaker.Logic;
using JsondataMaker.Models.GW0008.Request;
using JsondataMaker.Models.GW0008.Response;

namespace JsondataMaker.Controller
{
    public class DataMakerController
    {
        public void newJsonData(string apino, string reqOrRes, string path1, string path2)
        {
            // WIP: 入力ファイルが１つのAPI
            // テーブルクラスを作成して振り分ける isOneFile的な
            if (apino == "GW0008")
            {
                var reader = new StreamReader(path1);
                var csv = new CsvReader(reader);
                switch (apino)
                {
                    //Gw0008預金口座残高照会
                    case "GW0008":
                        var gw0008logic = new GW0008Logic();
                        if (reqOrRes == "Request")
                        {
                            var gw0008data = gw0008logic.ReadCsvRequest(csv);
                            foreach (RequestCsv data in gw0008data)
                            {
                                var outputData = gw0008logic.NewRequestJson(data);
                                var jf = new JsonFileWriter();
                                jf.New(outputData.RequestMessageData, outputData.FileNo, apino, reqOrRes);
                            }
                        }
                        else
                        {
                            var gw0008data = gw0008logic.ReadCsvResponse(csv);
                            foreach (ResponseCsv data in gw0008data)
                            {
                                var outputData = gw0008logic.NewResponseJson(data);
                                var jf = new JsonFileWriter();
                                jf.New(outputData.ResponseMessageData, outputData.FileNo, apino, reqOrRes);
                            }                         
                        }
                        break;
                }
            }
            // WIP: 入力ファイルが２つのAPI
            else
            {
                //do something
            }
        }
    }
}