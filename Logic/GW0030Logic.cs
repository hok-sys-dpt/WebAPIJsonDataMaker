using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0030.Request;
using WebAPIJsonDataMaker.Models.GW0030.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0030Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0030RequestCsv>();
            foreach (GW0030RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0030RequestCsv = data });
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
                GW0030RequestJson = new GW0030RequestJson()
                {
                    FileNo = data.GW0030RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        Tsumitateteikiyokinshiharai = data.GW0030RequestCsv.Tsumitateteikiyokinshiharai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0030RequestJson.RequestMessageData, outputData.GW0030RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0030ResponseCsv>();
            foreach (GW0030ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW0030ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0030ResponseJson = new GW0030ResponseJson()
                {
                    FileNo = data.GW0030ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        Tsumitateteikiyokinshiharai = data.GW0030ResponseCsv.Tsumitateteikiyokinshiharai
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW0030ResponseJson.ResponseMessageData, outputData.GW0030ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}