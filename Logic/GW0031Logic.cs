using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0031.Response;
using WebAPIJsonDataMaker.Models.GW0031;
using System.Linq;
using Newtonsoft.Json;
using System;
using WebAPIJsonDataMaker.Models.GW0031.Request;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0031Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0031RequestCsv>();
            foreach (GW0031RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0031RequestCsv = data });
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
                GW0031RequestJson = new GW0031RequestJson()
                {
                    FileNo = data.GW0031RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        TeikiyokinKinriShokai = data.GW0031RequestCsv.TeikiyokinKinriShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0031RequestJson.RequestMessageData, outputData.GW0031RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            var records = csv.GetRecords<GW0031ResponseCsv>();

            foreach (GW0031ResponseCsv data in records)
            {
                var records2 = csv2.GetRecords<KingakuKaiso>().ToArray();
                var model = new ResponseCsv()
                {
                    GW0031ResponseCsv = data
                };
                var i = 0;
                foreach (KingakuKaiso koza in records2)
                {
                    model.GW0031ResponseCsv.TeikiyokinKinriShokai.IbTeikiKinriShokaiOto.KingakuKaiso[i] = koza;
                    i++;
                }
                yield return (model);
            };
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0031ResponseJson = new GW0031ResponseJson()
                {
                    FileNo = data.GW0031ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        TeikiyokinKinriShokai = data.GW0031ResponseCsv.TeikiyokinKinriShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0031ResponseJson.ResponseMessageData, outputData.GW0031ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            throw new System.NotImplementedException();
        }
    }
}