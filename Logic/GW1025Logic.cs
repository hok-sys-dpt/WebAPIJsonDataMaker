using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1025.Request;
using WebAPIJsonDataMaker.Models.GW1025.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1025Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1025RequestCsv>();
            foreach (GW1025RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1025RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino)
        {
            var outputData = new RequestJson()
            {
                GW1025RequestJson = new GW1025RequestJson()
                {
                    FileNo = data.GW1025RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        BizIbHurikomihurikaeJokyoShokai = data.GW1025RequestCsv.BizIbHurikomihurikaeJokyoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1025RequestJson.RequestMessageData, outputData.GW1025RequestJson.FileNo, apino, "Request");
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1025ResponseCsv>();
            foreach (GW1025ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1025ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino)
        {
            var outputData = new ResponseJson()
            {
                GW1025ResponseJson = new GW1025ResponseJson()
                {
                    FileNo = data.GW1025ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        BizIbHurikomihurikaeJokyoShokai = data.GW1025ResponseCsv.BizIbHurikomihurikaeJokyoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1025ResponseJson.ResponseMessageData, outputData.GW1025ResponseJson.FileNo, apino, "Response");
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}