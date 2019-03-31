using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0026.Response;
using WebAPIJsonDataMaker.Models.GW0026;
using System.Linq;
using Newtonsoft.Json;
using System;
using WebAPIJsonDataMaker.Models.GW0026.Request;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0026Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0026RequestCsv>();
            foreach (GW0026RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0026RequestCsv = data });
            }
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW0026RequestJson = new GW0026RequestJson()
                {
                    FileNo = data.GW0026RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        TeikiyokinYonyuMeisaishokai = data.GW0026RequestCsv.TeikiyokinYonyuMeisaishokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0026RequestJson.RequestMessageData, outputData.GW0026RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            var records = csv.GetRecords<GW0026ResponseCsv>();

            foreach (GW0026ResponseCsv data in records)
            {
                var records2 = csv2.GetRecords<MeisaiItem>().ToArray();
                var model = new ResponseCsv()
                {
                    GW0026ResponseCsv = data
                };
                var i = 0;
                foreach (MeisaiItem item in records2)
                {
                    model.GW0026ResponseCsv.TeikiyokinYonyuMeisaishokai.IbTeikiMeisaiShokaiOto.MeisaiItem[i] = item;
                    i++;
                }
                yield return (model);
            };
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0026ResponseJson = new GW0026ResponseJson()
                {
                    FileNo = data.GW0026ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        TeikiyokinYonyuMeisaishokai = data.GW0026ResponseCsv.TeikiyokinYonyuMeisaishokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0026ResponseJson.ResponseMessageData, outputData.GW0026ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            throw new System.NotImplementedException();
        }
    }
}