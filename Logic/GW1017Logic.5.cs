using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1017.Request;
using WebAPIJsonDataMaker.Models.GW1017.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1017Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1017RequestCsv>();
            foreach (GW1017RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1017RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW1017RequestJson = new GW1017RequestJson()
                {
                    FileNo = data.GW1017RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        SenyoTozakashikoshiRisokuKeisanshoShokai = data.GW1017RequestCsv.SenyoTozakashikoshiRisokuKeisanshoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1017RequestJson.RequestMessageData, outputData.GW1017RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1017ResponseCsv>();
            foreach (GW1017ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1017ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1017ResponseJson = new GW1017ResponseJson()
                {
                    FileNo = data.GW1017ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        SenyoTozakashikoshiRisokuKeisanshoShokai = data.GW1017ResponseCsv.SenyoTozakashikoshiRisokuKeisanshoShokai
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW1017ResponseJson.ResponseMessageData, outputData.GW1017ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}