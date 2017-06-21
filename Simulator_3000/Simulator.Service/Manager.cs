using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator.Service
{
    public class Manager
    {
         Parser parser;
         Simulate simulate;
        

        public void SimulateStart(string name, int numCycles)
        {
            
            parser = new Parser(name);
            parser.Parse();
            simulate = new Simulate();
           
            simulate.Start(parser.type, parser.values, numCycles);

            Statistic.ExpCounter = simulate.ExpCounter;
            Statistic.SumExpCounter = simulate.SumExpCounter;
            Statistic.SilverCounter = simulate.SilverCounter;
            Statistic.SumSilverCounter = simulate.SumSilverCounter;
            Statistic.GoldCounter = simulate.GoldCounter;
            Statistic.SumGoldCounter = simulate.SumGoldCounter;
            Statistic.BlueprintCounter = simulate.BlueprintCounter;
            Statistic.SumBlueprintCounter = simulate.SumBlueprintCounter;
            Statistic.IDList.Clear();
            Statistic.expId.Clear();
            Statistic.goldId.Clear();
            Statistic.silvId.Clear();

            Statistic.IDList = simulate.idList;
            Statistic.Foo(Statistic.IDList);


        }

    }
}
