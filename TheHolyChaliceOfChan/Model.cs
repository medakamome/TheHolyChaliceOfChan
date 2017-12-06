using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TheHolyChaliceOfChan.Properties;

namespace TheHolyChaliceOfChan
{
    public class Model
    {
        public string OutDirectory { get; set; }
        public string Text{ get; set; }
        public double BaseLot { get; set; }
        public int Expiration { get; set; }
        public TimeSpan ExpirationTime { get; set; }
        public string ExpirationTimeStr { get { return ExpirationTime.ToString(); } }
        public bool RecommendTP { get; set; }
        public List<Data> DataList { get; set; }

        private List<KeyValuePair<string, string>> curPairList =
            new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("ドル円","USDJPY"),
                new KeyValuePair<string, string>("ユーロ円","EURJPY"),
                new KeyValuePair<string, string>("豪ドル円","AUDJPY"),
                new KeyValuePair<string, string>("ポンド円","GBPJPY"),
                new KeyValuePair<string, string>("NZドル円","NZDJPY"),
                new KeyValuePair<string, string>("ユーロドル","EURUSD"),
                new KeyValuePair<string, string>("ポンドドル","GBPUSD"),

            };

        public Model()
        {
            DataList = new List<Data>();
            BaseLot = Settings.Default.BaseLot;
            Expiration = Settings.Default.Expiration;
            OutDirectory = Settings.Default.OutDirectory;
            ExpirationTime = Settings.Default.ExpirationTime;
            RecommendTP = Settings.Default.RecommendTP;
        }

        public void Analyze()
        {
            if (String.IsNullOrEmpty(Text))
            {
                throw new Exception("解析対象データがありません。");
            }

            DataList.Clear();

            //string[,] curPaires = new string[,] 
            //{ 
            //    { "ドル円", "USDJPY" },
            //    { "ユーロ円", "EURJPY" }, 
            //    { "豪ドル円","AUDJPY" },
            //    { "ポンド円","GBPJPY" },
            //    { "NZドル円","NZDUSD" },
            //    { "ユーロドル","USDEUR" } };
            Regex reg = new Regex(" +");
            string[] lines = reg.Replace(Text.Replace("　", " "), " ").Replace("\r\n","!").Split('!');
            string tmp;
            string record = "";
            bool isFirst = true;
            string symbol = "";

            DateTime now = DateTime.Now;
            TimeSpan nowts = new TimeSpan(now.Hour, now.Minute, now.Second);
            TimeSpan expiration = nowts >= ExpirationTime ?
                new TimeSpan(24, 0, 0) - nowts + ExpirationTime :
                ExpirationTime - nowts;
            //expiration = expiration.TotalSeconds < 0 ? new TimeSpan(24, 0, 0) - expiration : expiration;

            foreach (string line in lines)
            {
                tmp = line.Trim(' ');
                

                foreach (KeyValuePair<string,string> curpair in curPairList)
                {
                    if (tmp.StartsWith(curpair.Key))
                    {
                        if (isFirst)
                        {
                            record = tmp;
                            isFirst = false;
                            symbol = curpair.Value;
                        }else
                        {
                            // 解析
                            Debug.WriteLine(record);
                            DataList.Add(AnalyzeLine(symbol, record, expiration));
                            record = tmp;
                            symbol = curpair.Value;

                        }
                        break;
                    }
                }
                if(record != tmp)
                {
                    record += " " + tmp.Trim(' ');
                }
            }
            // 最後の
            Debug.WriteLine(record);
            DataList.Add(AnalyzeLine(symbol, record, expiration));
        }

        private Data AnalyzeLine(string symbol, string line, TimeSpan expiration)
        {
            Data data = new Data();

            string[] datas = line.Split(' ');
            string tmp;
            double value;

            string regPattern1 = @"(\d+\.\d+)";
            string regPattern2 = @"\d+";
            string regPattern3 = @"[¥(（]売り[¥)）]";
            string regPattern4 = @"推奨＋([0-9]+)";

            DateTime now = DateTime.Now;
            TimeSpan nowTime = new TimeSpan(now.Hour, now.Minute, now.Second);

            //Regex reg1 = new Regex(@"(\d+\.\d+)");
            //Regex reg2 = new Regex(@"\d+");
            Match match;
            

            data.CurPair = symbol;
            data.Lot = this.BaseLot;
            match = new Regex(regPattern3).Match(line);
            //data.OrderMode = line.Contains("売り") ? 3 : 2;
            data.OrderMode = match.Success ? 3 : 2;
            match = new Regex(regPattern1).Match(line);
            if (double.TryParse(match.Value, out value))
            {
                data.Price = value;
            }
            tmp = datas[datas.ToList().FindIndex(item => item.Contains("損")) + 1];
            match = new Regex(regPattern2).Match(tmp);
            if(double.TryParse(match.Value, out value))
            {
                data.StopLoss =
                    data.Price - (data.OrderMode == 2 ? value : -value) / (data.Price > 50 ? 100 : 10000);
            }
            tmp = datas[datas.ToList().FindIndex(item => item.Contains("利確目標")) + 1];
            match = new Regex(regPattern2).Match(tmp);
            if (double.TryParse(match.Value, out value))
            {
                data.TakeProfit =
                    data.Price - (data.OrderMode == 2 ? -value : value) / (data.Price > 50 ? 100 : 10000);
            }
            match = new Regex(regPattern4).Match(line);
            if(double.TryParse(match.Groups[1].Value, out value))
            {
                data.RecommendTakeProfit =
                    data.Price - (data.OrderMode == 2 ? -value : value) / (data.Price > 50 ? 100 : 10000);
            } 
            data.DoOrder = true;
            data.Recommend = line.Contains("本日の") ? "◎" : "";
            //data.Expiration = Expiration * 60;
            //data.Expiration = nowTime <= ExpirationTime ? 0 : 0;
            data.Expiration = expiration.Hours * 60 * 60 + expiration.Minutes * 60 + expiration.Seconds;

            return data;
        }

        public void Output()
        {

            if (String.IsNullOrEmpty(OutDirectory))
            {
                throw new Exception("出力先を指定してください。");
            }

            if (DataList.Count(item => item.DoOrder) == 0)
            {
                throw new Exception("出力対象データがありません。");
            }

            Settings.Default.BaseLot = BaseLot;
            Settings.Default.Expiration = Expiration;
            TimeSpan ts;
            if(TimeSpan.TryParse(ExpirationTimeStr, out ts))
            {
                Settings.Default.ExpirationTime = ts;
            }
            Settings.Default.OutDirectory = OutDirectory;
            Settings.Default.RecommendTP = RecommendTP;
            Settings.Default.Save();

            string format = "{0},{1},{2},{3},{4},{5},{6}";

            using(StreamWriter sw = new StreamWriter(OutDirectory + @"\chan.csv"))
            {
                foreach (Data data in DataList)
                {
                    if (!data.DoOrder)
                        continue;

                    sw.WriteLine(
                        format,
                        data.CurPair,
                        data.OrderMode,
                        data.Lot,
                        data.Price,
                        RecommendTP ? data.RecommendTakeProfit : data.TakeProfit,
                        data.StopLoss,
                        data.Expiration
                        );

                }
            }
        }
    }
}
