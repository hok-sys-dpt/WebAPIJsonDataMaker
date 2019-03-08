using System.Collections.Generic;
using CsvHelper;
using JsondataMaker.Models.GW0012.Request;
using JsondataMaker.Models.GW0012.Response;
using JsondataMaker.Models.Common;
using Newtonsoft.Json;
using System;

namespace JsondataMaker.Logic
{
    public class GW0012Logic
    {
        public IEnumerable<GW0012RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0012RequestCsv>();
            foreach (GW0012RequestCsv data in records)
            {
                yield return (data);
            }
        }

        public GW0012RequestJson NewRequestJson(GW0012RequestCsv data)
        {
            var returnData = new GW0012RequestJson()
            {
                FileNo = data.FileId,
                RequestMessageData = new RequestMessageData()
                {
                    WisRequestSystemInfo = new WisRequestSystemInfo(),
                    GaikaYokinZandakaShokai = data.GaikaYokinZandakaShokai
                }
            };
            return (returnData);
        }

        public IEnumerable<GW0012ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0012ResponseCsv>();
            foreach (GW0012ResponseCsv data in records)
            {
                yield return (data);
            }
        }

        public GW0012ResponseJson NewResponseJson(GW0012ResponseCsv data)
        {
            var returnData = new GW0012ResponseJson()
            {
                FileNo = data.FileId,
                ResponseMessageData = new ResponseMessageData()
                {
                    WisResponseSystemInfo = new WisResponseSystemInfo(),
                    GaikaYokinZandakaShokai= data.GaikaYokinZandakaShokai
                }
            };
            return (returnData);
        }
    }
}