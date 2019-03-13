using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;

namespace WebAPIJsonDataMaker.Logic
{
    public interface IGWLogic
    {
        IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv);
        void NewRequestJson(RequestCsv data, string apino);
        IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv);
        void NewResponseJson(ResponseCsv data, string apino);
    }
}