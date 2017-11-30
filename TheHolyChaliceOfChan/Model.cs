using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
                new KeyValuePair<string, string>("ユーロドル","EURUSD")

            };

        public Model()
        {
            DataList = new List<Data>();
            BaseLot = 1.0;
        }

        public void Analyze()
        {
            if (String.IsNullOrEmpty(Text))
            {
                return;
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

            data.CurPair = symbol;
            data.Lot = this.BaseLot;
            data.OrderMode = line.Contains("売り") ? 3 : 2;
            data.Price = 0;
            tmp = datas[datas.ToList().FindIndex(item => item.Contains("損")) + 1];
            data.StopLoss = 0;
            tmp = datas[datas.ToList().FindIndex(item => item.Contains("利確目標")) + 1];
            data.TakeProfit = 0;
            data.DoOrder = true;

            return data;
        }

        public void Output()
        {

        }
    }
}
