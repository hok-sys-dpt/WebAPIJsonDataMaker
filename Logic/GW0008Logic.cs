using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0008.Request;
using WebAPIJsonDataMaker.Models.GW0008.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0008Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0008RequestCsv>();
            foreach (GW0008RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0008RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW0008RequestJson = new GW0008RequestJson()
                {
                    FileNo = data.GW0008RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        YokinkozaZandakashokai = data.GW0008RequestCsv.YokinkozaZandakashokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0008RequestJson.RequestMessageData, outputData.GW0008RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0008ResponseCsv>();
            foreach (GW0008ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW0008ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0008ResponseJson = new GW0008ResponseJson()
                {
                    FileNo = data.GW0008ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        YokinkozaZandakashokai = data.GW0008ResponseCsv.YokinkozaZandakashokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0008ResponseJson.ResponseMessageData, outputData.GW0008ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
        
        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2 ,CsvReader csv3)
        {
            throw new System.NotImplementedException();
        }
    }
}