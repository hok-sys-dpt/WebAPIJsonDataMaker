using System;
using System.IO;
using System.Text;
using CsvHelper;
using WebAPIJsonDataMaker.Logic;
using WebAPIJsonDataMaker.Models.Common;

namespace WebAPIJsonDataMaker.Controller
{
    public class DataMakerController
    {
        public void newJsonData(string apino, string reqOrRes, string path1, string path2, string outputpath)
        {

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var reader = new StreamReader(path1, Encoding.GetEncoding("shift-jis"));
            var csv = new CsvReader(reader);

            switch (apino)
            {
                //Gw0008預金口座残高照会
                case "GW0008":
                    {
                        IGWLogic iGWLogic = new GW0008Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }

                //Gw0012外貨預金残高照会
                case "GW0012":
                    {
                        IGWLogic iGWLogic = new GW0012Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //Gw0013外貨預金入出金明細照会
                case "GW0013":
                    {
                        IGWLogic iGWLogic = new GW0013Logic();
                        if (reqOrRes == "request")
                        {
                            newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        }
                        else
                        {
                            var reader2 = new StreamReader(path2, Encoding.GetEncoding("shift-jis"));
                            var csv2 = new CsvReader(reader2);
                            newListData(iGWLogic, csv, csv2, apino, reqOrRes, outputpath);
                        }
                        break;
                    }
                //Gw0019振込先口座照会
                case "GW0019":
                    {
                        IGWLogic iGWLogic = new GW0019Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //Gw0020振込実行
                case "GW0020":
                    {
                        IGWLogic iGWLogic = new GW0020Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //Gw0021振替
                case "GW0021":
                    {
                        IGWLogic iGWLogic = new GW0021Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //Gw0022振替
                case "GW0022":
                    {
                        IGWLogic iGWLogic = new GW0022Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //Gw0024定期預金追加預入
                case "GW0024":
                    {
                        IGWLogic iGWLogic = new GW0024Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //Gw0025積立定期預金追加預入
                case "GW0025":
                    {
                        IGWLogic iGWLogic = new GW0025Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW0026定期預金預入明細照会
                case "GW0026":
                    {
                        IGWLogic iGWLogic = new GW0026Logic();
                        if (reqOrRes == "request")
                        {
                            newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        }
                        else
                        {
                            var reader2 = new StreamReader(path2, Encoding.GetEncoding("shift-jis"));
                            var csv2 = new CsvReader(reader2);
                            newListData(iGWLogic, csv, csv2, apino, reqOrRes, outputpath);
                        }
                        break;
                    }
                //Gw0029定期預金支払
                case "GW0029":
                    {
                        IGWLogic iGWLogic = new GW0029Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //Gw0030積立定期預金支払
                case "GW0030":
                    {
                        IGWLogic iGWLogic = new GW0030Logic();
                //Gw0047MPN情報リンク表示項目照会
                case "GW0047":
                    {
                        IGWLogic iGWLogic = new GW0047Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //Gw0044MPN収納依頼
                case "GW0044":
                    {
                        IGWLogic iGWLogic = new GW0044Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW0045ＭＰＮ収納機関要否照会
                case "GW0045":
                    {
                        IGWLogic iGWLogic = new GW0045Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW0043MPN請求情報照会
                case "GW0043":
                    {
                        IGWLogic iGWLogic = new GW0043Logic();
                        if (reqOrRes == "request")
                        {
                            newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        }
                        else
                        {
                            var reader2 = new StreamReader(path2, Encoding.GetEncoding("shift-jis"));
                            var csv2 = new CsvReader(reader2);
                            newListData(iGWLogic, csv, csv2, apino, reqOrRes, outputpath);
                        }
                        break;
                    }
                //Gw0057振込予約実行
                case "GW0057":
                    {
                        IGWLogic iGWLogic = new GW0057Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //Gw1001法人IB契約者情報照会
                case "GW1001":
                    {
                        IGWLogic iGWLogic = new GW1001Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1002法人IB利用口座照会
                case "GW1002":
                    {
                        IGWLogic iGWLogic = new GW1002Logic();
                        if (reqOrRes == "request")
                        {
                            newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        }
                        else
                        {
                            var reader2 = new StreamReader(path2, Encoding.GetEncoding("shift-jis"));
                            var csv2 = new CsvReader(reader2);
                            newListData(iGWLogic, csv, csv2, apino, reqOrRes, outputpath);
                        }
                        break;
                    }
                //GW1003法人IB利用者照会
                case "GW1003":
                    {
                        IGWLogic iGWLogic = new GW1003Logic();
                        if (reqOrRes == "request")
                        {
                            newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        }
                        else
                        {
                            var reader2 = new StreamReader(path2, Encoding.GetEncoding("shift-jis"));
                            var csv2 = new CsvReader(reader2);
                            newListData(iGWLogic, csv, csv2, apino, reqOrRes, outputpath);
                        }
                        break;
                    }
                //GW1004総給振委託者情報照会
                case "GW1004":
                    {
                        IGWLogic iGWLogic = new GW1004Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1005口座振替委託者情報照会
                case "GW1005":
                    {
                        IGWLogic iGWLogic = new GW1005Logic();
                        if (reqOrRes == "request")
                        {
                            newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        }
                        else
                        {
                            var reader2 = new StreamReader(path2, Encoding.GetEncoding("shift-jis"));
                            var csv2 = new CsvReader(reader2);
                            newListData(iGWLogic, csv, csv2, apino, reqOrRes, outputpath);
                        }
                        break;
                    }
                //GW1006ＩＳ－ＮＥＴ委託者情報照会
                case "GW1006":
                    {
                        IGWLogic iGWLogic = new GW1006Logic();
                        if (reqOrRes == "request")
                        {
                            newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        }
                        else
                        {
                            var reader2 = new StreamReader(path2, Encoding.GetEncoding("shift-jis"));
                            var csv2 = new CsvReader(reader2);
                            newListData(iGWLogic, csv, csv2, apino, reqOrRes, outputpath);
                        }
                        break;
                    }
                //GW1007地方税納入契約者情報照会
                case "GW1007":
                    {
                        IGWLogic iGWLogic = new GW1007Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1008法人IB入出金明細照会
                case "GW1008":
                    {
                        IGWLogic iGWLogic = new GW1008Logic();
                        if (reqOrRes == "request")
                        {
                            newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        }
                        else
                        {
                            var reader2 = new StreamReader(path2, Encoding.GetEncoding("shift-jis"));
                            var csv2 = new CsvReader(reader2);
                            newListData(iGWLogic, csv, csv2, apino, reqOrRes, outputpath);
                        }
                        break;
                    }
                //GW1009法人IB入金通知情報更新
                case "GW1009":
                    {
                        IGWLogic iGWLogic = new GW1009Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1010法人IB利用者情報変更
                case "GW1010":
                    {
                        IGWLogic iGWLogic = new GW1010Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1011法人IB利用口座権限変更
                case "GW1011":
                    {
                        IGWLogic iGWLogic = new GW1011Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1012専用当座貸越実行
                case "GW1012":
                    {
                        IGWLogic iGWLogic = new GW1012Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1013専用当座貸越異例返済
                case "GW1013":
                    {
                        IGWLogic iGWLogic = new GW1013Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1014専用当座貸越実行予約
                case "GW1014":
                    {
                        IGWLogic iGWLogic = new GW1014Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1015専用当座貸越回収予約
                case "GW1015":
                    {
                        IGWLogic iGWLogic = new GW1015Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1017専用当座貸越計算書照会
                case "GW1017":
                    {
                        IGWLogic iGWLogic = new GW1017Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1019専用当座貸越借入内容照会
                case "GW1019":
                    {
                        IGWLogic iGWLogic = new GW1019Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1021法人IBパスワード認証
                case "GW1021":
                    {
                        IGWLogic iGWLogic = new GW1021Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1022外国為替相場一覧照会
                case "GW1022":
                    {
                        IGWLogic iGWLogic = new GW1022Logic();
                        if (reqOrRes == "request")
                        {
                            newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        }
                        else
                        {
                            var reader2 = new StreamReader(path2, Encoding.GetEncoding("shift-jis"));
                            var csv2 = new CsvReader(reader2);
                            newListData(iGWLogic, csv, csv2, apino, reqOrRes, outputpath);
                        }
                        break;
                    }
                //GW1023個社別外国為替相場照会
                case "GW1023":
                    {
                        IGWLogic iGWLogic = new GW1023Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1024定期預金受付状況照会
                case "GW1024":
                    {
                        IGWLogic iGWLogic = new GW1024Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1025IB振込振替状況照会
                case "GW1025":
                    {
                        IGWLogic iGWLogic = new GW1025Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1026B振込振替状況照会
                case "GW1026":
                    {
                        IGWLogic iGWLogic = new GW1026Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1016専用当座貸越取引明細照会
                case "GW1016":
                    {
                        IGWLogic iGWLogic = new GW1016Logic();
                        if (reqOrRes == "request")
                        {
                            newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        }
                        else
                        {
                            var reader2 = new StreamReader(path2, Encoding.GetEncoding("shift-jis"));
                            var csv2 = new CsvReader(reader2);
                            newListData(iGWLogic, csv, csv2, apino, reqOrRes, outputpath);
                        }
                        break;
                    }
                //GW1018専用当座貸越予約明細照会
                case "GW1018":
                    {
                        IGWLogic iGWLogic = new GW1018Logic();
                        if (reqOrRes == "request")
                        {
                            newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        }
                        else
                        {
                            var reader2 = new StreamReader(path2, Encoding.GetEncoding("shift-jis"));
                            var csv2 = new CsvReader(reader2);
                            newListData(iGWLogic, csv, csv2, apino, reqOrRes, outputpath);
                        }
                        break;
                    }
                //Gw1027MPN状況照会
                case "GW1027":
                    {
                        IGWLogic iGWLogic = new GW1027Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //GW1028法人IB予約取消
                case "GW1028":
                    {
                        IGWLogic iGWLogic = new GW1028Logic();
                        newData(iGWLogic, csv, apino, reqOrRes, outputpath);
                        break;
                    }
                //上記以外のAPI
                default:
                    throw new Exception("API番号が誤っています");
            }
        }

        public void newData(IGWLogic iGWLogic, CsvReader csv, string apino, string reqOrRes, string outputpath)
        {
            int i = 0;
            if (reqOrRes == "request")
            {
                var csvModel = iGWLogic.ReadCsvRequest(csv);
                foreach (RequestCsv data in csvModel)
                {
                    iGWLogic.NewRequestJson(data, apino, outputpath);
                    i++;
                }
            }
            else
            {
                var csvModel = iGWLogic.ReadCsvResponse(csv);
                foreach (ResponseCsv data in csvModel)
                {
                    iGWLogic.NewResponseJson(data, apino, outputpath);
                    i++;
                }
            }
            Console.WriteLine($"{i}件のファイルを出力しました");
        }

        public void newListData(IGWLogic iGWLogic, CsvReader csv, CsvReader csv2, string apino, string reqOrRes, string outputpath)
        {
            int i = 0;
            if (reqOrRes == "request")
            {
                throw new InvalidDataException();
            }
            else
            {
                var csvModel = iGWLogic.ReadCsvResponse(csv, csv2);
                foreach (ResponseCsv data in csvModel)
                {
                    iGWLogic.NewResponseJson(data, apino, outputpath);
                    i++;
                }
            }
            Console.WriteLine($"{i}件のファイルを出力しました");
        }
    }
}