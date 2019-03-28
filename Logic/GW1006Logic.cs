using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1006.Response;
using WebAPIJsonDataMaker.Models.GW1006;
using System.Linq;
using Newtonsoft.Json;
using System;
using WebAPIJsonDataMaker.Models.GW1006.Request;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1006Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1006RequestCsv>();
            foreach (GW1006RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1006RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW1006RequestJson = new GW1006RequestJson()
                {
                    FileNo = data.GW1006RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        IsnetItakushajohoShokai = data.GW1006RequestCsv.IsnetItakushajohoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1006RequestJson.RequestMessageData, outputData.GW1006RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            var records = csv.GetRecords<GW1006ResponseCsv>();

            foreach (GW1006ResponseCsv data in records)
            {
                var records2 = csv2.GetRecords<ItakushaJoho>().ToArray();
                var model = new ResponseCsv()
                {
                    GW1006ResponseCsv = data
                };
                var i = 0;
                foreach (ItakushaJoho koza in records2)
                {
                    model.GW1006ResponseCsv.IsnetItakushajohoShokai.ItakushaJoho[i] = koza;
                    i++;
                }
                yield return (model);
            };
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1006ResponseJson = new GW1006ResponseJson()
                {
                    FileNo = data.GW1006ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        IsnetItakushajohoShokai = data.GW1006ResponseCsv.IsnetItakushajohoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1006ResponseJson.ResponseMessageData, outputData.GW1006ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            throw new System.NotImplementedException();
        }
    }
}