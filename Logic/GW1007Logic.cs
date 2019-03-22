using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1007.Request;
using WebAPIJsonDataMaker.Models.GW1007.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1007Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1007RequestCsv>();
            foreach (GW1007RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1007RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino)
        {
            var outputData = new RequestJson()
            {
                GW1007RequestJson = new GW1007RequestJson()
                {
                    FileNo = data.GW1007RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        ChihozeinonyuKeiyakushajohoShokai = data.GW1007RequestCsv.ChihozeinonyuKeiyakushajohoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1007RequestJson.RequestMessageData, outputData.GW1007RequestJson.FileNo, apino, "Request");
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1007ResponseCsv>();
            foreach (GW1007ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1007ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino)
        {
            var outputData = new ResponseJson()
            {
                GW1007ResponseJson = new GW1007ResponseJson()
                {
                    FileNo = data.GW1007ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        ChihozeinonyuKeiyakushajohoShokai = data.GW1007ResponseCsv.ChihozeinonyuKeiyakushajohoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1007ResponseJson.ResponseMessageData, outputData.GW1007ResponseJson.FileNo, apino, "Response");
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}