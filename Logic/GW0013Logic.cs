using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0013.Response;
using WebAPIJsonDataMaker.Models.GW0013;
using System.Linq;
using Newtonsoft.Json;
using System;
using WebAPIJsonDataMaker.Models.GW0013.Request;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0013Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0013RequestCsv>();
            foreach (GW0013RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0013RequestCsv = data });
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
                GW0013RequestJson = new GW0013RequestJson()
                {
                    FileNo = data.GW0013RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        GaikaYokinNyushukkinMeisaiShokai = data.GW0013RequestCsv.GaikaYokinNyushukkinMeisaiShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0013RequestJson.RequestMessageData, outputData.GW0013RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            var records = csv.GetRecords<GW0013ResponseCsv>();

            foreach (GW0013ResponseCsv data in records)
            {
                var records2 = csv2.GetRecords<MeisaiJoho>().ToArray();
                var model = new ResponseCsv()
                {
                    GW0013ResponseCsv = data
                };
                var i = 0;
                foreach (MeisaiJoho koza in records2)
                {
                    model.GW0013ResponseCsv.GaikaYokinNyushukkinMeisaiShokai.MeisaiJoho[i] = koza;
                    i++;
                }
                yield return (model);
            };
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0013ResponseJson = new GW0013ResponseJson()
                {
                    FileNo = data.GW0013ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        GaikaYokinNyushukkinMeisaiShokai = data.GW0013ResponseCsv.GaikaYokinNyushukkinMeisaiShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0013ResponseJson.ResponseMessageData, outputData.GW0013ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            throw new System.NotImplementedException();
        }
    }
}