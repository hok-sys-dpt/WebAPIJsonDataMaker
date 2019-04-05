using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0022.Request;
using WebAPIJsonDataMaker.Models.GW0022.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0022Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0022RequestCsv>();
            foreach (GW0022RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0022RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW0022RequestJson = new GW0022RequestJson()
                {
                    FileNo = data.GW0022RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        GaikaFurikae = data.GW0022RequestCsv.GaikaFurikae
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0022RequestJson.RequestMessageData, outputData.GW0022RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0022ResponseCsv>();
            foreach (GW0022ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW0022ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0022ResponseJson = new GW0022ResponseJson()
                {
                    FileNo = data.GW0022ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        GaikaFurikae = data.GW0022ResponseCsv.GaikaFurikae
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW0022ResponseJson.ResponseMessageData, outputData.GW0022ResponseJson.FileNo, apino, "Response", outputpath);
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