using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHolyChaliceOfChan
{
    public class Model
    {
        public string OutDirectory { get; set; }
        public string Text{ get; set; }
        public List<Data> DataList { get; set; }

        public void Analyze()
        {
            if (String.IsNullOrEmpty(Text))
            {
                return;
            }

            string[] curPaires = new string[] { "ドル円", "ユーロ円","豪ドル円","ポンド円","NZドル円","ユーロドル"};

            string[] lines = Text.Replace("\r\n","!").Split('!');
            string tmp;
            string record = "";
            bool isFirst = true;
            foreach (string line in lines)
            {
                tmp = line.Trim('　');

                foreach (string curpair in curPaires)
                {
                    if (tmp.StartsWith(curpair))
                    {
                        if (isFirst)
                        {
                            record = tmp;
                            isFirst = false;
                        }else
                        {
                            // 解析
                            Debug.WriteLine(record);
                            record = tmp;

                        }
                        break;
                    }else
                    {
                        record += tmp;
                    }
                }
            }
        }

        public void Output()
        {

        }
    }
}
