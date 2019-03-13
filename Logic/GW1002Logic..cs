using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0012.Request;
using WebAPIJsonDataMaker.Models.GW1002.Response;
using WebAPIJsonDataMaker.Models.GW1002;
using System.Linq;
using Newtonsoft.Json;
using System;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1002Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            yield return (new RequestCsv());
            // var records = csv.GetRecords<GW1002ResponseCsv>();
            // foreach (GW1002ResponseCsv data in records)
            // {
            //     yield return (new RequestCsv() { GW1002ResponseCsv = data });
            // }
        }

        public void NewRequestJson(RequestCsv data, string apino)
        {
            var outputData = new RequestJson()
            {
                GW0012RequestJson = new GW0012RequestJson()
                {
                    FileNo = data.GW0012RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        GaikaYokinZandakaShokai = data.GW0012RequestCsv.GaikaYokinZandakaShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0012RequestJson.RequestMessageData, outputData.GW0012RequestJson.FileNo, apino, "Request");
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
                    model.GW1002ResponseCsv.IbRiyoukouzaShoukai.RiyoKozaJoho[i] = koza;
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
                        IbRiyoukouzaShoukai = data.GW1002ResponseCsv.IbRiyoukouzaShoukai
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