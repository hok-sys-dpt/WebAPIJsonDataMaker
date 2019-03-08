using System.Collections.Generic;
using CsvHelper;
using JsondataMaker.Models.GW0008.Request;
using JsondataMaker.Models.GW0008.Response;
using JsondataMaker.Models.Common;
using Newtonsoft.Json;
using System;

namespace JsondataMaker.Logic
{
    public class GW0008Logic
    {
        public IEnumerable<GW0008RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0008RequestCsv>();
            foreach (GW0008RequestCsv data in records)
            {
                yield return (data);
            }
        }

        public GW0008RequestJson NewRequestJson(GW0008RequestCsv data)
        {
            var returnData = new GW0008RequestJson()
            {
                FileNo = data.FileId,
                RequestMessageData = new RequestMessageData()
                {
                    WisRequestSystemInfo = new WisRequestSystemInfo(),
                    YokinkozaZandakashokai = data.YokinkozaZandakashokai
                }
            };
            return (returnData);
        }

        public IEnumerable<GW0008ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0008ResponseCsv>();
            foreach (GW0008ResponseCsv data in records)
            {
                yield return (data);
            }
        }

        public GW0008ResponseJson NewResponseJson(GW0008ResponseCsv data)
        {
            var returnData = new GW0008ResponseJson()
            {
                FileNo = data.FileId,
                ResponseMessageData = new ResponseMessageData()
                {
                    WisResponseSystemInfo = new WisResponseSystemInfo(),
                    YokinkozaZandakashokai = data.YokinkozaZandakashokai
                }
            };
            return (returnData);
        }
    }
}