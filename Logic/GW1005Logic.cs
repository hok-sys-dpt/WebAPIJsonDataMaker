using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1005.Response;
using WebAPIJsonDataMaker.Models.GW1005;
using System.Linq;
using Newtonsoft.Json;
using System;
using WebAPIJsonDataMaker.Models.GW1005.Request;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1005Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1005RequestCsv>();
            foreach (GW1005RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1005RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino)
        {
            var outputData = new RequestJson()
            {
                GW1005RequestJson = new GW1005RequestJson()
                {
                    FileNo = data.GW1005RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        KozafurikaeItakushajohoShokai = data.GW1005RequestCsv.KozafurikaeItakushajohoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1005RequestJson.RequestMessageData, outputData.GW1005RequestJson.FileNo, apino, "Request");
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            var records = csv.GetRecords<GW1005ResponseCsv>();

            foreach (GW1005ResponseCsv data in records)
            {
                var records2 = csv2.GetRecords<ItakushaJoho>().ToArray();
                var model = new ResponseCsv()
                {
                    GW1005ResponseCsv = data
                };
                var i = 0;
                foreach (ItakushaJoho koza in records2)
                {
                    model.GW1005ResponseCsv.KozafurikaeItakushajohoShokai.ItakushaJoho[i] = koza;
                    i++;
                }
                yield return (model);
            };
        }

        public void NewResponseJson(ResponseCsv data, string apino)
        {
            var outputData = new ResponseJson()
            {
                GW1005ResponseJson = new GW1005ResponseJson()
                {
                    FileNo = data.GW1005ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        KozafurikaeItakushajohoShokai = data.GW1005ResponseCsv.KozafurikaeItakushajohoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1005ResponseJson.ResponseMessageData, outputData.GW1005ResponseJson.FileNo, apino, "Response");
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            throw new System.NotImplementedException();
        }
    }
}