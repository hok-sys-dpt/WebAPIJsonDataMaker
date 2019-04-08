using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0029.Request;
using WebAPIJsonDataMaker.Models.GW0029.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0029Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0029RequestCsv>();
            foreach (GW0029RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0029RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW0029RequestJson = new GW0029RequestJson()
                {
                    FileNo = data.GW0029RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        Teikiyokinshiharai = data.GW0029RequestCsv.Teikiyokinshiharai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0029RequestJson.RequestMessageData, outputData.GW0029RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0029ResponseCsv>();
            foreach (GW0029ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW0029ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0029ResponseJson = new GW0029ResponseJson()
                {
                    FileNo = data.GW0029ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        Teikiyokinshiharai = data.GW0029ResponseCsv.Teikiyokinshiharai
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW0029ResponseJson.ResponseMessageData, outputData.GW0029ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}