using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0047.Request;
using WebAPIJsonDataMaker.Models.GW0047.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0047Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0047RequestCsv>();
            foreach (GW0047RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0047RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW0047RequestJson = new GW0047RequestJson()
                {
                    FileNo = data.GW0047RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        MpnJohorinkuHyojikomokuShokai = data.GW0047RequestCsv.MpnJohorinkuHyojikomokuShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0047RequestJson.RequestMessageData, outputData.GW0047RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0047ResponseCsv>();
            foreach (GW0047ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW0047ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0047ResponseJson = new GW0047ResponseJson()
                {
                    FileNo = data.GW0047ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        MpnJohorinkuHyojikomokuShokai= data.GW0047ResponseCsv.MpnJohorinkuHyojikomokuShokai
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW0047ResponseJson.ResponseMessageData, outputData.GW0047ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}