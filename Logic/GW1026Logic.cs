using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1026.Request;
using WebAPIJsonDataMaker.Models.GW1026.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1026Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1026RequestCsv>();
            foreach (GW1026RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1026RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW1026RequestJson = new GW1026RequestJson()
                {
                    FileNo = data.GW1026RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        BizIbGaikaJokyoShokai = data.GW1026RequestCsv.BizIbGaikaJokyoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1026RequestJson.RequestMessageData, outputData.GW1026RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1026ResponseCsv>();
            foreach (GW1026ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1026ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1026ResponseJson = new GW1026ResponseJson()
                {
                    FileNo = data.GW1026ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        BizIbGaikaJokyoShokai = data.GW1026ResponseCsv.BizIbGaikaJokyoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1026ResponseJson.ResponseMessageData, outputData.GW1026ResponseJson.FileNo, apino, "Response", outputpath);
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