using System;
using System.IO;
using CsvHelper;
using Newtonsoft.Json;
using System.Collections.Generic;
using JsonDataMaker.Logic;
using JsonDataMaker.Models.GW0008;

namespace JsonDataMaker.Controller
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
                            var gw0008data = gw0008logic.CsvRead(csv);
                            foreach (RequestCsv data in gw0008data)
                            {
                                var outputData = gw0008logic.NewCsv(data);
                                var jf = new JsonFileWriter();
                                jf.New(outputData.RequestMessageData, outputData.FileNo, apino, reqOrRes);
                            }
                        }
                        // WIP: ResponseDataの処理
                        else
                        {
                            //do something
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