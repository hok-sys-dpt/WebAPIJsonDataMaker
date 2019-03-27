using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1019.Request;
using WebAPIJsonDataMaker.Models.GW1019.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1019Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1019RequestCsv>();
            foreach (GW1019RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1019RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW1019RequestJson = new GW1019RequestJson()
                {
                    FileNo = data.GW1019RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        SenyoTozakashikoshiKariirenaiyoShokai = data.GW1019RequestCsv.SenyoTozakashikoshiKariirenaiyoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1019RequestJson.RequestMessageData, outputData.GW1019RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1019ResponseCsv>();
            foreach (GW1019ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1019ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1019ResponseJson = new GW1019ResponseJson()
                {
                    FileNo = data.GW1019ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        SenyoTozakashikoshiKariirenaiyoShokai = data.GW1019ResponseCsv.SenyoTozakashikoshiKariirenaiyoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1019ResponseJson.ResponseMessageData, outputData.GW1019ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}