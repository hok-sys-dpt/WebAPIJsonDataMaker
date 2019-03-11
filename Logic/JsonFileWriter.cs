using System;
using System.IO;
using Newtonsoft.Json;

namespace WebAPIJsonDataMaker.Logic
{
    public class JsonFileWriter
    {
        public void New(object model, string fileId, string apino, string reqOrRes)
        {
            var jsondata = JsonConvert.SerializeObject(model);
            Console.WriteLine(jsondata);
            StreamWriter writer = new StreamWriter(apino + reqOrRes + fileId + ".json", false);
            writer.WriteLine(jsondata);
            writer.Close();
        }
    }
}