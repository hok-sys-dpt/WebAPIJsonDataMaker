using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1009.Request;
using WebAPIJsonDataMaker.Models.GW1009.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1009Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1009RequestCsv>();
            foreach (GW1009RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1009RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW1009RequestJson = new GW1009RequestJson()
                {
                    FileNo = data.GW1009RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        NyukinTsuchiJohoKoshin = data.GW1009RequestCsv.NyukinTsuchiJohoKoshin
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1009RequestJson.RequestMessageData, outputData.GW1009RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1009ResponseCsv>();
            foreach (GW1009ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1009ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1009ResponseJson = new GW1009ResponseJson()
                {
                    FileNo = data.GW1009ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        NyukinTsuchiJohoKoshin = data.GW1009ResponseCsv.NyukinTsuchiJohoKoshin
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW1009ResponseJson.ResponseMessageData, outputData.GW1009ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
        
        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2 ,CsvReader csv3)
        {
            throw new System.NotImplementedException();
        }
    }
}