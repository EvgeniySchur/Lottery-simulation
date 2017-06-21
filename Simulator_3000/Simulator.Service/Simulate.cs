using System;
using System.Collections.Generic;

namespace Simulator.Service
{
    class Simulate
    {
        public int ExpCounter { get; set; }
        public int SilverCounter { get; set; }
        public int GoldCounter { get; set; }
        public int BlueprintCounter { get; set; }

        public int SumExpCounter { get; set; }
        public int SumSilverCounter { get; set; }
        public int SumGoldCounter { get; set; }
        public int SumBlueprintCounter { get; set; }

        public Dictionary<string,Dictionary<string, int>> idList = new Dictionary<string, Dictionary<string, int>>()
        {
            { "Experience", new Dictionary<string, int>() },
            { "Silver", new Dictionary<string, int>() },
            { "Gold", new Dictionary<string, int>() },
        };

        public Simulate()
        {
            ExpCounter = default(int);
            SilverCounter = default(int);
            GoldCounter = default(int);
            BlueprintCounter = default(int);
            SumExpCounter = default(int);
            SumSilverCounter = default(int);
            SumGoldCounter = default(int);
            SumBlueprintCounter = default(int);
        }

        public void Start(List<TypeOfValue> type, List<Data> values, int numCycles)
        {
            var chance = new Random();
            for (int i = 0; i < numCycles; i++)
            {

                var cT = chance.Next(100);
                var cV = chance.Next(10000);
                var drop = new Drop(type, values, cT, cV);
                if (drop.Type == "Experience")
                {
                    ExpCounter++;
                    SumExpCounter += int.Parse(drop.Value);
                    if (!idList["Experience"].ContainsKey(drop.ValueID))
                        idList["Experience"].Add(drop.ValueID, 1);
                    else
                        idList["Experience"][drop.ValueID] += 1;
                }
                if (drop.Type == "Blueprints")
                {
                    BlueprintCounter++;
                    SumBlueprintCounter+= int.Parse(drop.Value);

                }
                if (drop.Type == "Silver")
                {
                    SilverCounter++;
                    SumSilverCounter += int.Parse(drop.Value);
                    if (!idList["Silver"].ContainsKey(drop.ValueID))
                        idList["Silver"].Add(drop.ValueID, 1);
                    else
                        idList["Silver"][drop.ValueID] += 1;
                }
                if (drop.Type == "Gold")
                {
                    GoldCounter++;
                    SumGoldCounter += int.Parse(drop.Value);
                    if (!idList["Gold"].ContainsKey(drop.ValueID))
                        idList["Gold"].Add(drop.ValueID, 1);
                    else
                        idList["Gold"][drop.ValueID] += 1;
                }

            }
        }
    }
}
