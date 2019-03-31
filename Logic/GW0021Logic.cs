using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0021.Request;
using WebAPIJsonDataMaker.Models.GW0021.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0021Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0021RequestCsv>();
            foreach (GW0021RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0021RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW0021RequestJson = new GW0021RequestJson()
                {
                    FileNo = data.GW0021RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        Hurikae = data.GW0021RequestCsv.Hurikae
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0021RequestJson.RequestMessageData, outputData.GW0021RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0021ResponseCsv>();
            foreach (GW0021ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW0021ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0021ResponseJson = new GW0021ResponseJson()
                {
                    FileNo = data.GW0021ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        Hurikae = data.GW0021ResponseCsv.Hurikae
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW0021ResponseJson.ResponseMessageData, outputData.GW0021ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}