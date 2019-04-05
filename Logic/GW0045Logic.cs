using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0045.Request;
using WebAPIJsonDataMaker.Models.GW0045.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0045Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0045RequestCsv>();
            foreach (GW0045RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0045RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW0045RequestJson = new GW0045RequestJson()
                {
                    FileNo = data.GW0045RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        MpnShunokikanYohiShokai = data.GW0045RequestCsv.MpnShunokikanYohiShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0045RequestJson.RequestMessageData, outputData.GW0045RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0045ResponseCsv>();
            foreach (GW0045ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW0045ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0045ResponseJson = new GW0045ResponseJson()
                {
                    FileNo = data.GW0045ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        MpnShunokikanYohiShokai = data.GW0045ResponseCsv.MpnShunokikanYohiShokai
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW0045ResponseJson.ResponseMessageData, outputData.GW0045ResponseJson.FileNo, apino, "Response", outputpath);
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