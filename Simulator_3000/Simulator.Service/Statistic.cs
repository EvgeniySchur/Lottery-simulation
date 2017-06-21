using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Service
{
    public static class Statistic
    {
        public static int ExpCounter { get; set; }
        public static int SilverCounter { get; set; }
        public static int GoldCounter { get; set; }
        public static int BlueprintCounter { get; set; }

        public static int SumExpCounter { get; set; }
        public static int SumSilverCounter { get; set; }
        public static int SumGoldCounter { get; set; }
        public static int SumBlueprintCounter { get; set; }

        

        public static Dictionary<string, Dictionary<string, int>> IDList = new Dictionary<string, Dictionary<string, int>>();

        public static List<string> expId = new List<string>();
        public static List<string> silvId = new List<string>();
        public static List<string> goldId = new List<string>();

        public static void Foo(Dictionary<string, Dictionary<string, int>> IDList)
        {
            foreach (var item in IDList["Experience"])
            {
                expId.Add(item.Key.ToString() + "x" + item.Value.ToString());
            }
            foreach (var item in IDList["Silver"])
            {
                silvId.Add(item.Key.ToString() + "x" + item.Value.ToString());
            }
            foreach (var item in IDList["Gold"])
            {
                goldId.Add(item.Key.ToString() + "x" + item.Value.ToString());
            }
        }
    }
}
