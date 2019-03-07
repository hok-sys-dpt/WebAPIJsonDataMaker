using System;
using System.IO;
using Newtonsoft.Json;

namespace JsonDataMaker.Logic
{
    public class JsonFileWriter
    {
        public void New(object model, string fileId, string apino, string reqOrRes)
        {
            var jsondata = JsonConvert.SerializeObject(model);
            Console.WriteLine(jsondata);
            StreamWriter writer = new StreamWriter(apino + reqOrRes + fileId + ".json", true);
            writer.WriteLine(jsondata);
            writer.Close();
        }
    }
}