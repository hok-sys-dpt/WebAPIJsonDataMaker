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
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<RequestCsv>();
            foreach (RequestCsv data in records)
            {
                yield return (data);
            }
        }

        public RequestJson NewRequestJson(RequestCsv data)
        {
            var returnData = new RequestJson()
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

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<ResponseCsv>();
            foreach (ResponseCsv data in records)
            {
                yield return (data);
            }
        }

        public ResponseJson NewResponseJson(ResponseCsv data)
        {
            var returnData = new ResponseJson()
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