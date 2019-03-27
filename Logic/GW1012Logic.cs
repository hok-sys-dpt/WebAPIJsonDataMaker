using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1012.Request;
using WebAPIJsonDataMaker.Models.GW1012.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1012Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1012RequestCsv>();
            foreach (GW1012RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1012RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW1012RequestJson = new GW1012RequestJson()
                {
                    FileNo = data.GW1012RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        SenyotozakashikoshiJikko = data.GW1012RequestCsv.SenyotozakashikoshiJikko
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1012RequestJson.RequestMessageData, outputData.GW1012RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1012ResponseCsv>();
            foreach (GW1012ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1012ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1012ResponseJson = new GW1012ResponseJson()
                {
                    FileNo = data.GW1012ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        SenyotozakashikoshiJikko = data.GW1012ResponseCsv.SenyotozakashikoshiJikko
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1012ResponseJson.ResponseMessageData, outputData.GW1012ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}