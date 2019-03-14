using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0020.Request;
using WebAPIJsonDataMaker.Models.GW0020.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0020Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0020RequestCsv>();
            foreach (GW0020RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0020RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino)
        {
            var outputData = new RequestJson()
            {
                GW0020RequestJson = new GW0020RequestJson()
                {
                    FileNo = data.GW0020RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        HurikomiJikko = data.GW0020RequestCsv.HurikomiJikko
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0020RequestJson.RequestMessageData, outputData.GW0020RequestJson.FileNo, apino, "Request");
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0020ResponseCsv>();
            foreach (GW0020ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW0020ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino)
        {
            var outputData = new ResponseJson()
            {
                GW0020ResponseJson = new GW0020ResponseJson()
                {
                    FileNo = data.GW0020ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        HurikomiJikko = data.GW0020ResponseCsv.HurikomiJikko
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW0020ResponseJson.ResponseMessageData, outputData.GW0020ResponseJson.FileNo, apino, "Response");
        }
    }
}