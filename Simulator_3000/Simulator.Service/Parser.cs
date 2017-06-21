using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Simulator.Service
{
    public class Parser
    {
        string file;
        List<string> lines = new List<string>();
        public List<Data> values = new List<Data>();
        public List<TypeOfValue> type = new List<TypeOfValue>();

        public Parser(string name)
        {
            file = @"Content\" + name + ".csv";
        }
        public void Parse()
        {
            ReadAll();
        }
        void ReadAll()
        {
            if (File.Exists(file))
            {
                using (StreamReader sr = new StreamReader(file, Encoding.Default))
                {
                    var line = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }
            else
            {
                throw new Exception("file is damaged");
            }
            Distribution();
        }
        void Distribution()
        {
            var exp = false;
            var silver = false;
            var gold = false;
            
            for (int i = 1; i < lines.Count; i++)
            {

                var pair = lines[i].Split('#');
                if (i < 5)
                    type.Add(new TypeOfValue { Name = pair[0], Percent =pair[3] });
                if (i > 5 && pair[0] == "Experience")
                    exp = true;
                else if (pair[0] == string.Empty)
                    exp = false;
                if (i < lines.Count - 1)
                {
                    if (exp && lines[i + 1] != "###")
                        DataAdd(lines[i + 1], "Experience");
                }

                if (i > 5 && pair[0] == "Silver")
                    silver = true;
                else if (pair[0] == string.Empty)
                    silver = false;
                if (i < lines.Count - 1)
                {
                    if (silver && lines[i + 1] != "###")
                        DataAdd(lines[i + 1], "Silver");
                }

                if (i > 5 && pair[0] == "Gold")
                    gold = true;
                else if (pair[0] == string.Empty)
                    gold = false;
                if (i < lines.Count - 1)
                {
                    if (gold && lines[i + 1] != "###")
                        DataAdd(lines[i + 1], "Gold");
                }

            }
        }
       
        void DataAdd(string s, string name)
        {
            var pair = s.Split('#');
            values.Add(new Data { Name = name, ID = pair[0], Value = pair[1], Priority = pair[2], Percent = pair[3] });
        }
    }
}
