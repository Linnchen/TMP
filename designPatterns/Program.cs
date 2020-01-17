using System;
using System.Collections.Generic;
using System.IO;

namespace _15012020_design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IStrategy Strategy;
            Method Action;
            
            Strategy = new StrategySecondFolder();
            Action = new BinaryRead(Strategy.GetPath());

            List<string> data = Action.Execute();

            foreach (string s in data)
            {
                Console.WriteLine(s);
            }

            Strategy = new StrategyFirstFolder();
            Action = new TextRead(Strategy.GetPath());

            data = Action.Execute();

            foreach (string s in data)
            {
                Console.WriteLine(s);
            }
        }
    }
}
