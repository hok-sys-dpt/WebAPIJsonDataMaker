using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1023.Request;
using WebAPIJsonDataMaker.Models.GW1023.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1023Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1023RequestCsv>();
            foreach (GW1023RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1023RequestCsv = data });
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
                GW1023RequestJson = new GW1023RequestJson()
                {
                    FileNo = data.GW1023RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        KoshabetsuGaikokukawasesobaShokai = data.GW1023RequestCsv.KoshabetsuGaikokukawasesobaShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1023RequestJson.RequestMessageData, outputData.GW1023RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1023ResponseCsv>();
            foreach (GW1023ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1023ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1023ResponseJson = new GW1023ResponseJson()
                {
                    FileNo = data.GW1023ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        KoshabetsuGaikokukawasesobaShokai = data.GW1023ResponseCsv.KoshabetsuGaikokukawasesobaShokai
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW1023ResponseJson.ResponseMessageData, outputData.GW1023ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}