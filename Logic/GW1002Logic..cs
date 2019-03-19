using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1002.Response;
using WebAPIJsonDataMaker.Models.GW1002;
using System.Linq;
using Newtonsoft.Json;
using System;
using WebAPIJsonDataMaker.Models.GW1002.Request;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1002Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1002RequestCsv>();
            foreach (GW1002RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1002RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino)
        {
            var outputData = new RequestJson()
            {
                GW1002RequestJson = new GW1002RequestJson()
                {
                    FileNo = data.GW1002RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        BizIbRiyoukouzaShokai = data.GW1002RequestCsv.BizIbRiyoukouzaShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1002RequestJson.RequestMessageData, outputData.GW1002RequestJson.FileNo, apino, "Request");
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            var records = csv.GetRecords<GW1002ResponseCsv>();

            foreach (GW1002ResponseCsv data in records)
            {
                var records2 = csv2.GetRecords<RiyoKozaJoho>().ToArray();
                var model = new ResponseCsv()
                {
                    GW1002ResponseCsv = data
                };
                var i = 0;
                foreach (RiyoKozaJoho koza in records2)
                {
                    model.GW1002ResponseCsv.BizIbRiyoukouzaShokai.RiyoKozaJoho[i] = koza;
                    i++;
                }
                yield return (model);
            };
        }

        public void NewResponseJson(ResponseCsv data, string apino)
        {
            var outputData = new ResponseJson()
            {
                GW1002ResponseJson = new GW1002ResponseJson()
                {
                    FileNo = data.GW1002ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        BizIbRiyoukouzaShokai = data.GW1002ResponseCsv.BizIbRiyoukouzaShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1002ResponseJson.ResponseMessageData, outputData.GW1002ResponseJson.FileNo, apino, "Response");
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            throw new System.NotImplementedException();
        }
    }
}