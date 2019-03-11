using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using WebAPIJsonDataMaker.Controller;

namespace WebAPIJsonDataMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //コマンドラインの引数
            const int apiNo = 1;
            const int file1 = 3;
            const int file2 = 4;
            const int reqOrRes = 2;

            var cmd = Environment.GetCommandLineArgs();
            var count = cmd.Length;

            //コントローラー呼び出し
            var dc = new DataMakerController();
            dc.newJsonData(cmd[apiNo], cmd[reqOrRes], cmd[file1],cmd[file2]);
        }
    }
}