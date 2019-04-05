using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0011.Response;
using WebAPIJsonDataMaker.Models.GW0011;
using System.Linq;
using Newtonsoft.Json;
using System;
using WebAPIJsonDataMaker.Models.GW0011.Request;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0011Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0011RequestCsv>();
            foreach (GW0011RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0011RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW0011RequestJson = new GW0011RequestJson()
                {
                    FileNo = data.GW0011RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        GaikokuYokinKinriShoukai = data.GW0011RequestCsv.GaikokuYokinKinriShoukai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0011RequestJson.RequestMessageData, outputData.GW0011RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0011ResponseJson = new GW0011ResponseJson()
                {
                    FileNo = data.GW0011ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        GaikokuYokinKinriShoukai = data.GW0011ResponseCsv.GaikokuYokinKinriShoukai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0011ResponseJson.ResponseMessageData, outputData.GW0011ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            throw new System.NotImplementedException();
        }
        
        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2 ,CsvReader csv3)
        {
            
            var records = csv.GetRecords<GW0011ResponseCsv>();

            foreach (GW0011ResponseCsv data in records)
            {
                var records2 = csv2.GetRecords<TeikiRiritsuKingakubetsu>().ToArray();
                var records3 = csv3.GetRecords<TeikiRiritsuKikambetsu>().ToArray();
                var model = new ResponseCsv()
                {
                    GW0011ResponseCsv = data
                };
                var i = 0;
                foreach (TeikiRiritsuKingakubetsu kingakubetsu in records2)
                {
                    model.GW0011ResponseCsv.GaikokuYokinKinriShoukai.TeikiRiritsuJoho.TeikiRiritsuKingakubetsu[i] = kingakubetsu;
                    var j = 0;
                    foreach (TeikiRiritsuKikambetsu kikambetsu in records3)
                    {
                        model.GW0011ResponseCsv.GaikokuYokinKinriShoukai.TeikiRiritsuJoho.TeikiRiritsuKingakubetsu.TeikiRiritsuKikambetsu[j] = kikambetsu;
                        i++;
                    }
                    i++;
                }
                yield return (model);
            };
        }
    }
}