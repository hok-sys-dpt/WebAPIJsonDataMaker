using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1016.Response;
using WebAPIJsonDataMaker.Models.GW1016;
using System.Linq;
using Newtonsoft.Json;
using System;
using WebAPIJsonDataMaker.Models.GW1016.Request;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1016Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1016RequestCsv>();
            foreach (GW1016RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1016RequestCsv = data });
            }
        }

        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW1016RequestJson = new GW1016RequestJson()
                {
                    FileNo = data.GW1016RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        SenyotozakashikoshiTorihikiMeisaiShokai = data.GW1016RequestCsv.SenyotozakashikoshiTorihikiMeisaiShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1016RequestJson.RequestMessageData, outputData.GW1016RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            var records = csv.GetRecords<GW1016ResponseCsv>();

            foreach (GW1016ResponseCsv data in records)
            {
                var records2 = csv2.GetRecords<TorihikiMeisai>().ToArray();
                var model = new ResponseCsv()
                {
                    GW1016ResponseCsv = data
                };
                var i = 0;
                foreach (TorihikiMeisai koza in records2)
                {
                    model.GW1016ResponseCsv.SenyotozakashikoshiTorihikiMeisaiShokai.TorihikiMeisai[i] = koza;
                    i++;
                }
                yield return (model);
            };
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1016ResponseJson = new GW1016ResponseJson()
                {
                    FileNo = data.GW1016ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        SenyotozakashikoshiTorihikiMeisaiShokai = data.GW1016ResponseCsv.SenyotozakashikoshiTorihikiMeisaiShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1016ResponseJson.ResponseMessageData, outputData.GW1016ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            throw new System.NotImplementedException();
        }
    }
}