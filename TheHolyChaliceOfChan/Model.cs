using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TheHolyChaliceOfChan.Properties;

namespace TheHolyChaliceOfChan
{
    public class Model
    {
        public string OutDirectory { get; set; }
        public string Text{ get; set; }
        public double BaseLot { get; set; }
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
            OutDirectory = Settings.Default.OutDirectory;
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
                            DataList.Add(AnalyzeLine(symbol, record));
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
            DataList.Add(AnalyzeLine(symbol, record));
        }

        private Data AnalyzeLine(string symbol, string line)
        {
            Data data = new Data();

            string[] datas = line.Split(' ');
            string tmp;
            double value;
            Regex reg1 = new Regex(@"(\d+\.\d+)");
            Match match;
            Regex reg2 = new Regex(@"\d+");
            
            data.CurPair = symbol;
            data.Lot = this.BaseLot;
            data.OrderMode = line.Contains("売り") ? 3 : 2;
            match = reg1.Match(line);
            if (double.TryParse(match.Value, out value))
            {
                data.Price = value;
            }
            tmp = datas[datas.ToList().FindIndex(item => item.Contains("損")) + 1];
            match = reg2.Match(tmp);
            if(double.TryParse(match.Value, out value))
            {
                data.StopLoss =
                    data.Price - (data.OrderMode == 2 ? value : -value) / (data.Price > 50 ? 100 : 10000);
            }
            tmp = datas[datas.ToList().FindIndex(item => item.Contains("利確目標")) + 1];
            match = reg2.Match(tmp);
            if (double.TryParse(match.Value, out value))
            {
                data.TakeProfit =
                    data.Price - (data.OrderMode == 2 ? -value : value) / (data.Price > 50 ? 100 : 10000);
            }
            data.DoOrder = true;
            data.Recommend = line.Contains("本日の") ? "◎" : "";
            data.Expiration = 12 * 60 * 60;

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
            Settings.Default.OutDirectory = OutDirectory;
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
                        data.TakeProfit,
                        data.StopLoss,
                        data.Expiration
                        );

                }
            }
        }
    }
}
