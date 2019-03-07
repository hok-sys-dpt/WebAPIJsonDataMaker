using System.Collections.Generic;
using CsvHelper;
using JsonDataMaker.Models.GW0008;
using JsonDataMaker.Models.Common;
using Newtonsoft.Json;
using System;

namespace JsonDataMaker.Logic
{
    public class GW0008Logic
    {
        public IEnumerable<RequestCsv> CsvRead(CsvReader csv)
        {
            // csv.Configuration.RegisterClassMap<RequestCsvMap>();
            var records = csv.GetRecords<RequestCsv>();
            foreach (RequestCsv data in records)
            {
                yield return (data);
            }
        }

        public RequestJson NewCsv(RequestCsv data)
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
    }
}