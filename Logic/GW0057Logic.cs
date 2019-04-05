using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0057.Request;
using WebAPIJsonDataMaker.Models.GW0057.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0057Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0057RequestCsv>();
            foreach (GW0057RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0057RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW0057RequestJson = new GW0057RequestJson()
                {
                    FileNo = data.GW0057RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        HurikomiJikko = data.GW0057RequestCsv.HurikomiJikko
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0057RequestJson.RequestMessageData, outputData.GW0057RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0057ResponseCsv>();
            foreach (GW0057ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW0057ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0057ResponseJson = new GW0057ResponseJson()
                {
                    FileNo = data.GW0057ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        HurikomiJikko = data.GW0057ResponseCsv.HurikomiJikko
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW0057ResponseJson.ResponseMessageData, outputData.GW0057ResponseJson.FileNo, apino, "Response", outputpath);
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