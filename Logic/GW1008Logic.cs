using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW1008.Response;
using WebAPIJsonDataMaker.Models.GW1008;
using System.Linq;
using Newtonsoft.Json;
using System;
using WebAPIJsonDataMaker.Models.GW1008.Request;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW1008Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW1008RequestCsv>();
            foreach (GW1008RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW1008RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW1008RequestJson = new GW1008RequestJson()
                {
                    FileNo = data.GW1008RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        BizIbNyushukkinMeisaiShokai = data.GW1008RequestCsv.BizIbNyushukkinMeisaiShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1008RequestJson.RequestMessageData, outputData.GW1008RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            var records = csv.GetRecords<GW1008ResponseCsv>();

            foreach (GW1008ResponseCsv data in records)
            {
                var records2 = csv2.GetRecords<NyushukkinMeisaiJoho>().ToArray();
                var model = new ResponseCsv()
                {
                    GW1008ResponseCsv = data
                };
                var i = 0;
                foreach (NyushukkinMeisaiJoho meisai in records2)
                {
                    model.GW1008ResponseCsv.BizIbNyushukkinMeisaiShokai.NyushukkinMeisaiJoho[i] = meisai;
                    i++;
                }
                yield return (model);
            };
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW1008ResponseJson = new GW1008ResponseJson()
                {
                    FileNo = data.GW1008ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        BizIbNyushukkinMeisaiShokai = data.GW1008ResponseCsv.BizIbNyushukkinMeisaiShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW1008ResponseJson.ResponseMessageData, outputData.GW1008ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            throw new System.NotImplementedException();
        }
        
        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2 ,CsvReader csv3)
        {
            throw new System.NotImplementedException();
        }
    }
}