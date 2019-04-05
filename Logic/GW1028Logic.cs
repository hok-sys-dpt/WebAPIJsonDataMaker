using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1028.Request;
using WebAPIJsonDataMaker.Models.GW1028.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1028Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1028RequestCsv>();
            foreach (GW1028RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1028RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW1028RequestJson = new GW1028RequestJson()
                {
                    FileNo = data.GW1028RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        BizIbYoyakuTorikeshi = data.GW1028RequestCsv.BizIbYoyakuTorikeshi
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1028RequestJson.RequestMessageData, outputData.GW1028RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1028ResponseCsv>();
            foreach (GW1028ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1028ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1028ResponseJson = new GW1028ResponseJson()
                {
                    FileNo = data.GW1028ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        BizIbYoyakuTorikeshi = data.GW1028ResponseCsv.BizIbYoyakuTorikeshi
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW1028ResponseJson.ResponseMessageData, outputData.GW1028ResponseJson.FileNo, apino, "Response", outputpath);
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