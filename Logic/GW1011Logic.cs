using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1011.Request;
using WebAPIJsonDataMaker.Models.GW1011.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1011Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1011RequestCsv>();
            foreach (GW1011RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1011RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW1011RequestJson = new GW1011RequestJson()
                {
                    FileNo = data.GW1011RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        KozaRiyoKengenHenko = data.GW1011RequestCsv.KozaRiyoKengenHenko
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1011RequestJson.RequestMessageData, outputData.GW1011RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1011ResponseCsv>();
            foreach (GW1011ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1011ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1011ResponseJson = new GW1011ResponseJson()
                {
                    FileNo = data.GW1011ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        KozaRiyoKengenHenko = data.GW1011ResponseCsv.KozaRiyoKengenHenko
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW1011ResponseJson.ResponseMessageData, outputData.GW1011ResponseJson.FileNo, apino, "Response", outputpath);
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