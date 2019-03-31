using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1024.Request;
using WebAPIJsonDataMaker.Models.GW1024.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1024Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1024RequestCsv>();
            foreach (GW1024RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1024RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW1024RequestJson = new GW1024RequestJson()
                {
                    FileNo = data.GW1024RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        BizIbTeikiJyokyoShokai = data.GW1024RequestCsv.BizIbTeikiJyokyoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1024RequestJson.RequestMessageData, outputData.GW1024RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1024ResponseCsv>();
            foreach (GW1024ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1024ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1024ResponseJson = new GW1024ResponseJson()
                {
                    FileNo = data.GW1024ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        BizIbTeikiJyokyoShokai = data.GW1024ResponseCsv.BizIbTeikiJyokyoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1024ResponseJson.ResponseMessageData, outputData.GW1024ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}