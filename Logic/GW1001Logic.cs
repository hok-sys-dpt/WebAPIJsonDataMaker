using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1001.Request;
using WebAPIJsonDataMaker.Models.GW1001.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1001Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1001RequestCsv>();
            foreach (GW1001RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1001RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino)
        {
            var outputData = new RequestJson()
            {
                GW1001RequestJson = new GW1001RequestJson()
                {
                    FileNo = data.GW1001RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        BizIbKeiyakushaJohoShokai = data.GW1001RequestCsv.BizIbKeiyakushaJohoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1001RequestJson.RequestMessageData, outputData.GW1001RequestJson.FileNo, apino, "Request");
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1001ResponseCsv>();
            foreach (GW1001ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1001ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino)
        {
            var outputData = new ResponseJson()
            {
                GW1001ResponseJson = new GW1001ResponseJson()
                {
                    FileNo = data.GW1001ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        BizIbKeiyakushaJohoShokai = data.GW1001ResponseCsv.BizIbKeiyakushaJohoShokai
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW1001ResponseJson.ResponseMessageData, outputData.GW1001ResponseJson.FileNo, apino, "Response");
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}