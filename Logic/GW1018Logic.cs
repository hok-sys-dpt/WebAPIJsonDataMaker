using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1018.Response;
using WebAPIJsonDataMaker.Models.GW1018;
using System.Linq;
using Newtonsoft.Json;
using System;
using WebAPIJsonDataMaker.Models.GW1018.Request;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1018Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1018RequestCsv>();
            foreach (GW1018RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1018RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW1018RequestJson = new GW1018RequestJson()
                {
                    FileNo = data.GW1018RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        SenyotozakashikoshiYoyakuMeisaiShokai = data.GW1018RequestCsv.SenyotozakashikoshiYoyakuMeisaiShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1018RequestJson.RequestMessageData, outputData.GW1018RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            var records = csv.GetRecords<GW1018ResponseCsv>();

            foreach (GW1018ResponseCsv data in records)
            {
                var records2 = csv2.GetRecords<YoyakuMeisai>().ToArray();
                var model = new ResponseCsv()
                {
                    GW1018ResponseCsv = data
                };
                var i = 0;
                foreach (YoyakuMeisai meisai in records2)
                {
                    model.GW1018ResponseCsv.SenyotozakashikoshiYoyakuMeisaiShokai.YoyakuMeisai[i] = meisai;
                    i++;
                }
                yield return (model);
            };
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1018ResponseJson = new GW1018ResponseJson()
                {
                    FileNo = data.GW1018ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        SenyotozakashikoshiYoyakuMeisaiShokai = data.GW1018ResponseCsv.SenyotozakashikoshiYoyakuMeisaiShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1018ResponseJson.ResponseMessageData, outputData.GW1018ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            throw new System.NotImplementedException();
        }
    }
}