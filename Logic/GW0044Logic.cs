using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;
using WebAPIJsonDataMaker.Models.GW0044.Request;
using WebAPIJsonDataMaker.Models.GW0044.Response;
using System.Linq;
using Newtonsoft.Json;
using System;

namespace WebAPIJsonDataMaker.Logic
{
    public class GW0044Logic : IGWLogic
    {
        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv, CsvReader csv2)
        {
            var records = csv.GetRecords<GW0044RequestCsv>();

            foreach (GW0044RequestCsv data in records)
            {
                var records2 = csv2.GetRecords<HosutoShoriTsubanJoho>().ToArray();
                var model = new RequestCsv()
                {
                    GW0044RequestCsv = data
                };
                var i = 0;
                foreach (HosutoShoriTsubanJoho koza in records2)
                {
                    model.GW0044RequestCsv.MpnShunoIrai.HosutoShoriTsubanJoho[i] = koza;
                    i++;
                }
                yield return (model);
            };
        }

        public void NewRequestJson(RequestCsv data, string apino, string outputpath)
        {
            var outputData = new RequestJson()
            {
                GW0044RequestJson = new GW0044RequestJson()
                {
                    FileNo = data.GW0044RequestCsv.FileId,
                    RequestMessageData = new RequestMessageData()
                    {
                        WisRequestSystemInfo = new WisRequestSystemInfo(),
                        MpnShunoIrai = data.GW0044RequestCsv.MpnShunoIrai
                    }
                }
            };
            var jf = new JsonFileWriter();
            jf.New(outputData.GW0044RequestJson.RequestMessageData, outputData.GW0044RequestJson.FileNo, apino, "Request", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv)
        {
            var records = csv.GetRecords<GW0044ResponseCsv>();
            foreach (GW0044ResponseCsv data in records)
            {
                yield return (new ResponseCsv() { GW0044ResponseCsv = data });
            }
        }

        public void NewResponseJson(ResponseCsv data, string apino, string outputpath)
        {
            var outputData = new ResponseJson()
            {
                GW0044ResponseJson = new GW0044ResponseJson()
                {
                    FileNo = data.GW0044ResponseCsv.FileId,
                    ResponseMessageData = new ResponseMessageData()
                    {
                        WisResponseSystemInfo = new WisResponseSystemInfo(),
                        MpnShunoIrai = data.GW0044ResponseCsv.MpnShunoIrai
                    }
                }
            };
                        var jf = new JsonFileWriter();
            jf.New(outputData.GW0044ResponseJson.ResponseMessageData, outputData.GW0044ResponseJson.FileNo, apino, "Response", outputpath);
        }

        public IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2)
        {
            throw new System.NotImplementedException();
        }
    }
}