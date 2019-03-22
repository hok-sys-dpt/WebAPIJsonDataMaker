using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1003.Response;
using WebAPIJsonDataMaker.Models.GW1003;
using System.Linq;
using Newtonsoft.Json;
using System;
using WebAPIJsonDataMaker.Models.GW1003.Request;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1003Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1003RequestCsv>();
            foreach (GW1003RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1003RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino)
        {
            var outputData = new RequestJson()
            {
                GW1003RequestJson = new GW1003RequestJson()
                {
                    FileNo = data.GW1003RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        BizIbRiyoshaShokai = data.GW1003RequestCsv.BizIbRiyoshaShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1003RequestJson.RequestMessageData, outputData.GW1003RequestJson.FileNo, apino, "Request");
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            var records = csv.GetRecords<GW1003ResponseCsv>();

            foreach (GW1003ResponseCsv data in records)
            {
                var records2 = csv2.GetRecords<RiyoshaJoho>().ToArray();
                var model = new ResponseCsv()
                {
                    GW1003ResponseCsv = data
                };
                var i = 0;
                foreach (RiyoshaJoho riyosha in records2)
                {
                    model.GW1003ResponseCsv.BizIbRiyoshaShokai.RiyoshaJoho[i] = riyosha;
                    i++;
                }
                yield return (model);
            };
        }

        public void NewResponseJson(ResponseCsv data, string apino)
        {
            var outputData = new ResponseJson()
            {
                GW1003ResponseJson = new GW1003ResponseJson()
                {
                    FileNo = data.GW1003ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        BizIbRiyoshaShokai = data.GW1003ResponseCsv.BizIbRiyoshaShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1003ResponseJson.ResponseMessageData, outputData.GW1003ResponseJson.FileNo, apino, "Response");
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            throw new System.NotImplementedException();
        }
    }
}