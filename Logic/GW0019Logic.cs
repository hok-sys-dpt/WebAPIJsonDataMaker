using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0019.Request;
using WebAPIJsonDataMaker.Models.GW0019.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0019Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0019RequestCsv>();
            foreach (GW0019RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0019RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW0019RequestJson = new GW0019RequestJson()
                {
                    FileNo = data.GW0019RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        HurikomisakiKozaShokai = data.GW0019RequestCsv.HurikomisakiKozaShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0019RequestJson.RequestMessageData, outputData.GW0019RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0019ResponseCsv>();
            foreach (GW0019ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW0019ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0019ResponseJson = new GW0019ResponseJson()
                {
                    FileNo = data.GW0019ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        HurikomisakiKozaShokai = data.GW0019ResponseCsv.HurikomisakiKozaShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0019ResponseJson.ResponseMessageData, outputData.GW0019ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}