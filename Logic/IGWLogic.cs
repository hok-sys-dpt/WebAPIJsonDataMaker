using System.Collections.Generic;
using CsvHelper;
using WebAPIJsonDataMaker.Models.Common;

namespace WebAPIJsonDataMaker.Logic
{
    public interface IGWLogic
    {
        IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv);
        IEnumerable<RequestCsv> ReadCsvRequest(CsvReader csv, CsvReader csv2);
        void NewRequestJson(RequestCsv data, string apino, string outputpath);
        IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv);
        void NewResponseJson(ResponseCsv data, string apino, string outputpath);
        IEnumerable<ResponseCsv> ReadCsvResponse(CsvReader csv, CsvReader csv2);
    }
}