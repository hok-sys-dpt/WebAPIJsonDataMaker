using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1022.Response;
using WebAPIJsonDataMaker.Models.GW1022;
using System.Linq;
using Newtonsoft.Json;
using System;
using WebAPIJsonDataMaker.Models.GW1022.Request;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1022Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1022RequestCsv>();
            foreach (GW1022RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1022RequestCsv = data });
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
                GW1022RequestJson = new GW1022RequestJson()
                {
                    FileNo = data.GW1022RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        GaikokukawasesobaIchiranShokai = data.GW1022RequestCsv.GaikokukawasesobaIchiranShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1022RequestJson.RequestMessageData, outputData.GW1022RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            var records = csv.GetRecords<GW1022ResponseCsv>();

            foreach (GW1022ResponseCsv data in records)
            {
                var records2 = csv2.GetRecords<SobaJoho>().ToArray();
                var model = new ResponseCsv()
                {
                    GW1022ResponseCsv = data
                };
                var i = 0;
                foreach (SobaJoho joho in records2)
                {
                    model.GW1022ResponseCsv.GaikokukawasesobaIchiranShokai.SobaJoho[i] = joho;
                    i++;
                }
                yield return (model);
            };
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1022ResponseJson = new GW1022ResponseJson()
                {
                    FileNo = data.GW1022ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        GaikokukawasesobaIchiranShokai = data.GW1022ResponseCsv.GaikokukawasesobaIchiranShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1022ResponseJson.ResponseMessageData, outputData.GW1022ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            throw new System.NotImplementedException();
        }
    }
}