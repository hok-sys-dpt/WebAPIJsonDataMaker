using System;
using System.Collections.Generic;
using CommandLine;
using Newtonsoft.Json;
using WebAPIJsonDataMaker.Controller;
using WebAPIJsonDataMaker.Logic;

namespace WebAPIJsonDataMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n 処理を開始します");
            var dc = new DataMakerController();
            try
            {
                Parser.Default.ParseArguments<Options>(args).WithParsed<Options>(o =>
                {
                    var reqOrRes = o.reqOrRes.ToLower();
                    if (reqOrRes == "request" || reqOrRes == "response")
                    {
                        dc.newJsonData(o.apiNo, reqOrRes, o.file1Name, o.file2Name, o.outputpath);
                        Console.WriteLine("\n 正常に終了しました");
                    }
                    else
                    {
                        throw new Exception("Request または Responseを指定して下さい");
                    }
                });
            }
            catch (Exception e)
            {
                Console.WriteLine("\n エラーが発生ました");
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.Write("\n キーを押して終了してください");
                Console.ReadKey(true);
            }
        }
    }
}