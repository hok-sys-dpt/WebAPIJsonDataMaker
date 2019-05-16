using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1029.Response;
using WebAPIJsonDataMaker.Models.GW1029;
using System.Linq;
using Newtonsoft.Json;
using System;
using WebAPIJsonDataMaker.Models.GW1029.Request;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1029Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1029RequestCsv>();
            foreach (GW1029RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1029RequestCsv = data });
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
                GW1029RequestJson = new GW1029RequestJson()
                {
                    FileNo = data.GW1029RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        BizIbSenyotozakashikoshiRiyoukozaShokai = data.GW1029RequestCsv.BizIbSenyotozakashikoshiRiyoukozaShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1029RequestJson.RequestMessageData, outputData.GW1029RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            var records = csv.GetRecords<GW1029ResponseCsv>();

            foreach (GW1029ResponseCsv data in records)
            {
                var records2 = csv2.GetRecords<SenyoTozakashikoshiRiyoukozaJoho>().ToArray();
                var model = new ResponseCsv()
                {
                    GW1029ResponseCsv = data
                };
                var i = 0;
                foreach (SenyoTozakashikoshiRiyoukozaJoho koza in records2)
                {
                    model.GW1029ResponseCsv.BizIbSenyotozakashikoshiRiyoukozaShokai.SenyoTozakashikoshiRiyoukozaJoho[i] = koza;
                    i++;
                }
                yield return (model);
            };
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1029ResponseJson = new GW1029ResponseJson()
                {
                    FileNo = data.GW1029ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        BizIbSenyotozakashikoshiRiyoukozaShokai = data.GW1029ResponseCsv.BizIbSenyotozakashikoshiRiyoukozaShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1029ResponseJson.ResponseMessageData, outputData.GW1029ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            throw new System.NotImplementedException();
        }
    }
}