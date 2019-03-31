using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0025.Request;
using WebAPIJsonDataMaker.Models.GW0025.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0025Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0025RequestCsv>();
            foreach (GW0025RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0025RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW0025RequestJson = new GW0025RequestJson()
                {
                    FileNo = data.GW0025RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        TsumitateTeikiyokinTsuikaYonyu = data.GW0025RequestCsv.TsumitateTeikiyokinTsuikaYonyu
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0025RequestJson.RequestMessageData, outputData.GW0025RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0025ResponseCsv>();
            foreach (GW0025ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW0025ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0025ResponseJson = new GW0025ResponseJson()
                {
                    FileNo = data.GW0025ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        TsumitateTeikiyokinTsuikaYonyu = data.GW0025ResponseCsv.TsumitateTeikiyokinTsuikaYonyu
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW0025ResponseJson.ResponseMessageData, outputData.GW0025ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}