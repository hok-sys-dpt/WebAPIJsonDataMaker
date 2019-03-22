using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1004.Request;
using WebAPIJsonDataMaker.Models.GW1004.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1004Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1004RequestCsv>();
            foreach (GW1004RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1004RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino)
        {
            var outputData = new RequestJson()
            {
                GW1004RequestJson = new GW1004RequestJson()
                {
                    FileNo = data.GW1004RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        SokyufuriItakushajohoShokai = data.GW1004RequestCsv.SokyufuriItakushajohoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1004RequestJson.RequestMessageData, outputData.GW1004RequestJson.FileNo, apino, "Request");
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1004ResponseCsv>();
            foreach (GW1004ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1004ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino)
        {
            var outputData = new ResponseJson()
            {
                GW1004ResponseJson = new GW1004ResponseJson()
                {
                    FileNo = data.GW1004ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        SokyufuriItakushajohoShokai = data.GW1004ResponseCsv.SokyufuriItakushajohoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1004ResponseJson.ResponseMessageData, outputData.GW1004ResponseJson.FileNo, apino, "Response");
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}