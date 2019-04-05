using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0024.Request;
using WebAPIJsonDataMaker.Models.GW0024.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0024Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0024RequestCsv>();
            foreach (GW0024RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0024RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW0024RequestJson = new GW0024RequestJson()
                {
                    FileNo = data.GW0024RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        TeikiyokinTsuikaYonyu = data.GW0024RequestCsv.TeikiyokinTsuikaYonyu
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0024RequestJson.RequestMessageData, outputData.GW0024RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0024ResponseCsv>();
            foreach (GW0024ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW0024ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0024ResponseJson = new GW0024ResponseJson()
                {
                    FileNo = data.GW0024ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        TeikiyokinTsuikaYonyu = data.GW0024ResponseCsv.TeikiyokinTsuikaYonyu
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW0024ResponseJson.ResponseMessageData, outputData.GW0024ResponseJson.FileNo, apino, "Response", outputpath);
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