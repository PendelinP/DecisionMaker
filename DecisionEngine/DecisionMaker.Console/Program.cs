using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecisionMaker.Engine;

namespace DecisionMaker.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var decisionEngine = new DecisionEngine();

            //var groups = Enumerable.Range(0, 1000000).Select(i => decisionEngine.MakeDecision()).GroupBy(p => p).ToDictionary(p => p.Count(), p => p.Key);

            while (true)
            {
                //System.Console.WriteLine(decisionEngine.MakeDecision());

                System.Console.WriteLine(decisionEngine.MakeDecision(new[] { "1", "2" }));

                System.Console.ReadLine();
            }
        }
    }
}
