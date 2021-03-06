using System;
using System.IO;
using Newtonsoft.Json;
using System.Globalization;

namespace WebAPIJsonDataMaker.Logic
{
    public class JsonFileWriter
    {
        public void New(object model, int fileId, string apino, string reqOrRes, string outputpath)
        {
            TextInfo myTI = new CultureInfo("en-US",false).TextInfo;

            var jsondata = JsonConvert.SerializeObject(model, Formatting.Indented);
            StreamWriter writer = new StreamWriter($"{outputpath}/{apino}{myTI.ToTitleCase(reqOrRes)}{fileId:D4}.json", false);
            writer.WriteLine(jsondata);
            writer.Close();
        }
    }
}