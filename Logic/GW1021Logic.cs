using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1021.Request;
using WebAPIJsonDataMaker.Models.GW1021.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1021Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1021RequestCsv>();
            foreach (GW1021RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1021RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW1021RequestJson = new GW1021RequestJson()
                {
                    FileNo = data.GW1021RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        BizIbPasswordNinsho = data.GW1021RequestCsv.BizIbPasswordNinsho
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1021RequestJson.RequestMessageData, outputData.GW1021RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1021ResponseCsv>();
            foreach (GW1021ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1021ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1021ResponseJson = new GW1021ResponseJson()
                {
                    FileNo = data.GW1021ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        BizIbPasswordNinsho = data.GW1021ResponseCsv.BizIbPasswordNinsho
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1021ResponseJson.ResponseMessageData, outputData.GW1021ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}