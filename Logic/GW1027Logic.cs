using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1027.Request;
using WebAPIJsonDataMaker.Models.GW1027.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1027Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1027RequestCsv>();
            foreach (GW1027RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1027RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW1027RequestJson = new GW1027RequestJson()
                {
                    FileNo = data.GW1027RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        BizIbMpnJokyoShokai = data.GW1027RequestCsv.BizIbMpnJokyoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1027RequestJson.RequestMessageData, outputData.GW1027RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1027ResponseCsv>();
            foreach (GW1027ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1027ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1027ResponseJson = new GW1027ResponseJson()
                {
                    FileNo = data.GW1027ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        BizIbMpnJokyoShokai = data.GW1027ResponseCsv.BizIbMpnJokyoShokai
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW1027ResponseJson.ResponseMessageData, outputData.GW1027ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}