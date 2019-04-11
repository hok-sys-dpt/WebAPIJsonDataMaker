using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1013.Request;
using WebAPIJsonDataMaker.Models.GW1013.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1013Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1013RequestCsv>();
            foreach (GW1013RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1013RequestCsv = data });
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
                GW1013RequestJson = new GW1013RequestJson()
                {
                    FileNo = data.GW1013RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        SenyotozakashikoshiIreiHensai = data.GW1013RequestCsv.SenyotozakashikoshiIreiHensai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1013RequestJson.RequestMessageData, outputData.GW1013RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1013ResponseCsv>();
            foreach (GW1013ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1013ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1013ResponseJson = new GW1013ResponseJson()
                {
                    FileNo = data.GW1013ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        SenyotozakashikoshiIreiHensai = data.GW1013ResponseCsv.SenyotozakashikoshiIreiHensai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1013ResponseJson.ResponseMessageData, outputData.GW1013ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}