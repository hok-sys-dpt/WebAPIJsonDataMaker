using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1010.Request;
using WebAPIJsonDataMaker.Models.GW1010.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1010Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1010RequestCsv>();
            foreach (GW1010RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1010RequestCsv = data });
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
                GW1010RequestJson = new GW1010RequestJson()
                {
                    FileNo = data.GW1010RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        RiyoshaJohoHenko = data.GW1010RequestCsv.RiyoshaJohoHenko
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1010RequestJson.RequestMessageData, outputData.GW1010RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1010ResponseCsv>();
            foreach (GW1010ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1010ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1010ResponseJson = new GW1010ResponseJson()
                {
                    FileNo = data.GW1010ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        RiyoshaJohoHenko = data.GW1010ResponseCsv.RiyoshaJohoHenko
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW1010ResponseJson.ResponseMessageData, outputData.GW1010ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}