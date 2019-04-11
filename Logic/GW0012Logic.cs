using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0012.Request;
using WebAPIJsonDataMaker.Models.GW0012.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0012Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0012RequestCsv>();
            foreach (GW0012RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0012RequestCsv = data });
            }
        }
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW0012RequestJson = new GW0012RequestJson()
                {
                    FileNo = data.GW0012RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        GaikaYokinZandakaShokai = data.GW0012RequestCsv.GaikaYokinZandakaShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0012RequestJson.RequestMessageData, outputData.GW0012RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0012ResponseCsv>();
            foreach (GW0012ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW0012ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0012ResponseJson = new GW0012ResponseJson()
                {
                    FileNo = data.GW0012ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        GaikaYokinZandakaShokai = data.GW0012ResponseCsv.GaikaYokinZandakaShokai
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW0012ResponseJson.ResponseMessageData, outputData.GW0012ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}