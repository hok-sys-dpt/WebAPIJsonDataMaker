using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0043.Response;
using WebAPIJsonDataMaker.Models.GW0043;
using System.Linq;
using Newtonsoft.Json;
using System;
using WebAPIJsonDataMaker.Models.GW0043.Request;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0043Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            var records = csv.GetRecords<GW0043RequestCsv>();
            foreach (GW0043RequestCsv data in records)
            {
                yield return (new RequestCsv() { GW0043RequestCsv = data });
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
                GW0043RequestJson = new GW0043RequestJson()
                {
                    FileNo = data.GW0043RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        MpnSeikyujohoShokai = data.GW0043RequestCsv.MpnSeikyujohoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0043RequestJson.RequestMessageData, outputData.GW0043RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            var records = csv.GetRecords<GW0043ResponseCsv>();

            foreach (GW0043ResponseCsv data in records)
            {
                var records2 = csv2.GetRecords<HosutoShoriTsubanJoho>().ToArray();
                var model = new ResponseCsv()
                {
                    GW0043ResponseCsv = data
                };
                var i = 0;
                foreach (HosutoShoriTsubanJoho joho in records2)
                {
                    model.GW0043ResponseCsv.MpnSeikyujohoShokai.HosutoShoriTsubanJoho[i] = joho;
                    i++;
                }
                yield return (model);
            };
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0043ResponseJson = new GW0043ResponseJson()
                {
                    FileNo = data.GW0043ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        MpnSeikyujohoShokai = data.GW0043ResponseCsv.MpnSeikyujohoShokai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0043ResponseJson.ResponseMessageData, outputData.GW0043ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            throw new System.NotImplementedException();
        }
    }
}