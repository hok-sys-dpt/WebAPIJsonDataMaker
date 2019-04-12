using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1015.Request;
using WebAPIJsonDataMaker.Models.GW1015.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1015Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1015RequestCsv>();
            foreach (GW1015RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1015RequestCsv = data });
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
                GW1015RequestJson = new GW1015RequestJson()
                {
                    FileNo = data.GW1015RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        SenyotozakashikoshiKaishuYoyaku = data.GW1015RequestCsv.SenyotozakashikoshiKaishuYoyaku
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1015RequestJson.RequestMessageData, outputData.GW1015RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1015ResponseCsv>();
            foreach (GW1015ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1015ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1015ResponseJson = new GW1015ResponseJson()
                {
                    FileNo = data.GW1015ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        SenyotozakashikoshiKaishuYoyaku = data.GW1015ResponseCsv.SenyotozakashikoshiKaishuYoyaku
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW1015ResponseJson.ResponseMessageData, outputData.GW1015ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}