using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1014.Request;
using WebAPIJsonDataMaker.Models.GW1014.Response;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1014Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1014RequestCsv>();
            foreach (GW1014RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1014RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW1014RequestJson = new GW1014RequestJson()
                {
                    FileNo = data.GW1014RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        SenyotozakashikoshiJikkoYoyaku = data.GW1014RequestCsv.SenyotozakashikoshiJikkoYoyaku
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1014RequestJson.RequestMessageData, outputData.GW1014RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW1014ResponseCsv>();
            foreach (GW1014ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW1014ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1014ResponseJson = new GW1014ResponseJson()
                {
                    FileNo = data.GW1014ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        SenyotozakashikoshiJikkoYoyaku = data.GW1014ResponseCsv.SenyotozakashikoshiJikkoYoyaku
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW1014ResponseJson.ResponseMessageData, outputData.GW1014ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}