using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1020.Request;
using WebAPIJsonDataMaker.Models.GW1020.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1020Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1020RequestCsv>();
            foreach (GW1020RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1020RequestCsv = data });
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
                GW1020RequestJson = new GW1020RequestJson()
                {
                    FileNo = data.GW1020RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        BizIbSenyotozakashikoshiJokyoShokai  = data.GW1020RequestCsv.BizIbSenyotozakashikoshiJokyoShokai 
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1020RequestJson.RequestMessageData, outputData.GW1020RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1020ResponseCsv>();
            foreach (GW1020ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1020ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1020ResponseJson = new GW1020ResponseJson()
                {
                    FileNo = data.GW1020ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        BizIbSenyotozakashikoshiJokyoShokai = data.GW1020ResponseCsv.BizIbSenyotozakashikoshiJokyoShokai
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW1020ResponseJson.ResponseMessageData, outputData.GW1020ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}